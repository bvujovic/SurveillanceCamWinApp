using SurveillanceCamWinApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveillanceCamWinApp.Classes
{
    /// <summary>
    /// Globalni podaci za aplikaciju.
    /// </summary>
    public static class AppData
    {
        private static string rootImageFolder;

        public static string RootImageFolder
        {
            get { return rootImageFolder; }
            set { rootImageFolder = value; } //TODO ovde ubaciti neku validaciju i copy/move sadrzaja foldera
        }

        public static List<Camera> Cameras { get; private set; } = new List<Camera>();

        public static List<DateDir> DateDirs { get; private set; } = new List<DateDir>();

        public static void LoadAppData()
        {
            using (var db = new Data.DbCtx())
            {
                var appSettings = db.AppSettings.ToList();
                RootImageFolder = appSettings.FirstOrDefault(it => it.Name == nameof(RootImageFolder))?.Value;
                Cameras = db.Cameras.ToList();
            }
        }

        public static void SaveAppData()
        {
            using (var db = new Data.DbCtx())
            {
                var appSettings = db.AppSettings.ToList();
                if (RootImageFolder != null)
                {
                    var rootImgFolder = appSettings.FirstOrDefault(it => it.Name == nameof(RootImageFolder));
                    if (rootImgFolder == null)
                        db.AppSettings.Add(new AppSetting(nameof(RootImageFolder), RootImageFolder));
                    else
                        rootImgFolder.Value = RootImageFolder;
                }

                db.SaveChanges();
            }
        }
    }
}
