using SurveillanceCamWinApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SurveillanceCamWinApp.Data.Models
{
    /// <summary>
    /// Klasa ciji objekti predstavljaju direktorijum u kojem su slike napravljene jednog datuma.
    /// </summary>
    public class DateDir
    {
        public DateDir(Camera cam, string name)
        {
            Camera = cam;
            Name = name;
            CalcImgCountLocal();
        }

        public static void Parse(Camera cam, string resp)
        {
            var lines = resp.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines.Where(it => !it.StartsWith("/System Volume")))
            {
                var name = line.Substring(1);
                if (!AppData.DateDirs.Any(it => it.Camera.IdCam == cam.IdCam && it.Name == name))
                    AppData.DateDirs.Add(new DateDir(cam, name));
            }
        }

        private void CalcImgCountLocal()
        {
            ImgCountLocal = System.IO.Directory.Exists(LocalDirPath) ?
                System.IO.Directory.GetFiles(LocalDirPath).Length : 0;
        }

        //[Key]
        //public int IdDateDir { get; set; }

        /// <summary>Kamera za koju su vezane slike iz ovog foldera-datuma.</summary>
        public Camera Camera { get; set; }

        /// <summary>Naziv foldera - datum slika u formatu yyyy-mm-dd.</summary>
        public string Name { get; set; }

        /// <summary>Broj slika na SD kartici.</summary>
        public int? ImgCountSDC { get; set; }

        /// <summary>Broj skinutih slika na racunaru.</summary>
        public int ImgCountLocal { get; set; }

        /// <summary></summary>
        public string LocalDirPath
            => System.IO.Path.Combine(AppData.RootImageFolder, Camera.DeviceName, Name);

        public override string ToString()
            => $"{Camera.DeviceName}/{Name}";
    }
}
