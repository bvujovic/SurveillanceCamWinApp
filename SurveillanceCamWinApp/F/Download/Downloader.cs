﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using SurveillanceCamWinApp.Classes;
using SurveillanceCamWinApp.Data.Models;

namespace SurveillanceCamWinApp.F.Download
{
    /// <summary>
    /// Klasa koja je zaduzena za skidanje foldera i fajlova sa SD kartice na lokalni drajv.
    /// </summary>
    public static class Downloader
    {
        public static async Task<string> GetDirs(CamDate cd)
        {
            if (TestData.IsEnabled)
                return cd.Date.HasValue ? TestData.ListSdCardFiles : TestData.ListSdCardDirs;

            var url = $"http://{cd.Camera.IpAddress}/listSdCard";
            if (cd.Date.HasValue)
            {
                var dt = cd.Date.Value;
                url += $"?y={dt.Year}&m={dt.Month}&d={dt.Day}";
            }

            // https://stackoverflow.com/questions/27108264/how-to-properly-make-a-http-web-get-request
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Timeout = 3000;
            using (var response = (HttpWebResponse)request.GetResponse())
            using (var stream = response.GetResponseStream())
            using (var reader = new System.IO.StreamReader(stream))
                return await reader.ReadToEndAsync();
        }

        /// <see cref="https://stackoverflow.com/questions/24797485/how-to-download-image-from-url"/>
        public static async Task GetImage(ImageFile img)
        {
            if (img.ExistsLocally)
                return;
            var dd = img.DateDir;
            //          http://192.168.0.60/sdCardImg?img=/2021-08-21/03.46.36.jpg
            var url = $"http://{dd.Camera.IpAddress}/sdCardImg?img=/{dd.Name}/{img.Name}";
            Logger.OutputEventTime($"GetImage beg: {img.Name}");
            using (var client = new WebClient())
                await client.DownloadFileTaskAsync(new Uri(url), img.LocalImagePath);
            Logger.OutputEventTime($"GetImage end: {img.Name}");
        }

        public static async Task GetDateDir(DateDir dateDir)
        {
            if (!System.IO.Directory.Exists(dateDir.LocalDirPath))
                System.IO.Directory.CreateDirectory(dateDir.LocalDirPath);
            // pozivanje GetImage() za sve slike
            foreach (var img in dateDir.ImageFiles)
                await GetImage(img);
        }

        /// <summary>Download for CamDate/ImageFile/DateDir is finished.</summary>
        public static event EventHandler Finished;

        /// <summary>Download is started.</summary>
        public static event EventHandler Started;

        private readonly static List<object> downloads = new List<object>();

        //B private static bool inProgress = false;
        public static bool InProgress { get; private set; } = false;

        /// <summary>Dodaje trazeni objekat u listu za download.</summary>
        /// <param name="input">ImageFile/DateDir/CamDate</param>
        public static void AddDownload(object input)
        {
            if (input is DateDir dd)
                downloads.Add(new CamDate(dd.Camera, DateTime.Parse(dd.Name)));

            downloads.Add(input);
            Console.WriteLine($"DLs count: {downloads.Count}");
            if (!InProgress)
            {
                Started?.Invoke(input, EventArgs.Empty);
                _ = Download();
            }
        }

        private static async Task Download()
        {
            var dl = downloads.First();
            downloads.RemoveAt(0);
            Logger.OutputEventTime($"Download: {dl}");
            try
            {
                if (dl is ImageFile img)
                    await GetImage(img);
                if (dl is DateDir dd)
                    await GetDateDir(dd);
                if (dl is CamDate cd)
                {
                    var resp = await GetDirs(cd);
                    if (!cd.Date.HasValue)
                        DateDir.Parse(cd.Camera, resp);
                    else
                        ImageFile.Parse(cd.Camera.GetDateDir(cd.Date.Value), resp);
                }
            }
            catch (Exception ex)
            {
                Logger.OutputEventTime(ex.Message);
            }
            Logger.OutputEventTime($"Finished: {dl}");
            Finished?.Invoke(dl, EventArgs.Empty);

            //TODO razmisliti sta tacno oznacava Started i Finished
            // mozda mi trebaju 2 para strat finish dogadjaja: jedan par za jedan DL, a jedan za sve


            if (downloads.Count > 0)
                await Download();
            else
                InProgress = false;
        }
    }

    //public enum DLType
    //{
    //    Dir, File, Query //?Root, QueryDir
    //}
}
