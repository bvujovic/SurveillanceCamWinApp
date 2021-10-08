using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveillanceCamWinApp.Classes
{
    /// <summary>
    /// Klasa je zaduzena za upisivanje poruka u log fajl.
    /// </summary>
    public static class Logger
    {
        private const string fileName = "messages.log";

        public static void CreateFolderIN()
        {
            if (!Directory.Exists(AppData.RootImageFolder))
                Directory.CreateDirectory(AppData.RootImageFolder);
        }

        public static void AddToLog(Exception ex)
        {
            var msg = ex.Message;
            //B
            //var apiex = ex as TO.APINGException;
            //if (apiex != null)
            //    msg = apiex.ErrorCode + ", details: " + apiex.ErrorDetails;
            AddToLog(msg + Environment.NewLine + ex.StackTrace);
        }

        public static void AddToLog(string msg)
        {
            try
            {
                using (var sw = new StreamWriter(Path.Combine(AppData.RootImageFolder, fileName), true))
                    sw.WriteLine($"{DateTime.Now.ToString(Utils.DatumVremeSveFormat)} - {msg}\r\n");
                AddedToLog?.Invoke(null, msg);
                Statuses.Add(msg);
            }
            catch { }
        }

        public static event EventHandler<string> AddedToLog;

        public static List<string> Statuses { get; private set; } = new List<string>();

        /// <summary>U konzoli prikazuje vreme (sec:ms) nekog dogadjaja.</summary>
        public static void OutputEventTime(string eventName)
            => Console.WriteLine(Utils.CurrentTimeMS + " - " + eventName);

    }
}
