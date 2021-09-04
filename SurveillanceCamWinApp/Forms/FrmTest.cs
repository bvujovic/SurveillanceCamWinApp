using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SurveillanceCamWinApp.Classes;
using SurveillanceCamWinApp.Data.Models;
using SurveillanceCamWinApp.F.Download;

namespace SurveillanceCamWinApp.Forms
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();

            cam = new Camera { DeviceName = "Test Cam", IpLastNum = 60 };

            AppData.RootImageFolder = @"d:\Glavni\TempDownloads\SurveillanceCam\";
            Downloader.Started += Downloader_Started;
            Downloader.Finished += Downloader_Finished;
        }

        readonly Camera cam;

        private void Downloader_Started(object sender, EventArgs e)
        {
            btnDlDateDir.BackColor = Color.Green;
        }

        private void Downloader_Finished(object o, EventArgs e)
        {
            btnDlDateDir.BackColor = this.BackColor;
            if (o is CamDate cd)
                Console.WriteLine(cd);

            if (o is ImageFile img)
            {
                if (img.ExistsLocally)
                    System.Diagnostics.Process.Start(img.LocalImagePath);
            }

            if (o is DateDir dd)
                System.Diagnostics.Process.Start(dd.LocalDirPath);
        }

        private void BtnDlRootDirs_Click(object sender, EventArgs e)
        {
            var cd = new CamDate(cam, null);
            Downloader.AddDownload(cd);
        }

        private void BtnDlDir_Click(object sender, EventArgs e)
        {
            var cd = new CamDate(cam, new DateTime(2021, 08, 26));
            Downloader.AddDownload(cd);
        }

        private void BtnDlRootAndDir_Click(object sender, EventArgs e)
        {
            var cd = new CamDate(cam, null);
            Downloader.AddDownload(cd);
            cd = new CamDate(cam, new DateTime(2021, 08, 26));
            Downloader.AddDownload(cd);
        }

        private void BtnDlImage_Click(object sender, EventArgs e)
        {
            var img = new ImageFile(cam.GetDateDir(DateTime.Parse("2021-08-26")), "05.28.50.jpg");
            Downloader.AddDownload(img);
        }

        private void BtnDlImages_Click(object sender, EventArgs e)
        {
            var dd = cam.GetDateDir(DateTime.Parse("2021-08-26"));
            var img = new ImageFile(dd, "05.28.50.jpg");
            Downloader.AddDownload(img);
            img = new ImageFile(dd, "05.27.15.jpg");
            Downloader.AddDownload(img);
            img = new ImageFile(dd, "05.27.30.jpg");
            Downloader.AddDownload(img);
        }

        private void BtnDlDateDir_Click(object sender, EventArgs e)
        {
            var dd = cam.GetDateDir(DateTime.Parse("2021-08-30"));
            Downloader.AddDownload(dd);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new Data.DbCtx())
                {
                    ctx.Cameras.Add(cam);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex) { Utils.ShowMbox(ex, btnSave.Text); }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new Data.DbCtx())
                {
                    var cams = ctx.Cameras.ToList();
                    var dirs = ctx.DateDirs.ToList();
                    var imgs = ctx.ImageFiles.ToList();
                    Console.WriteLine(cams);
                }
            }
            catch (Exception ex) { Utils.ShowMbox(ex, btnLoad.Text); }
        }
    }
}
