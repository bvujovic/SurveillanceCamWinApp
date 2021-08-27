using SurveillanceCamWinApp.Classes;
using SurveillanceCamWinApp.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveillanceCamWinApp.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                //T
                //calendar.AddBoldedDate(DateTime.Now);
                //calendar.AddBoldedDate(DateTime.Now.AddDays(2));
                //calendar.UpdateBoldedDates();

                AppData.LoadAppData();

                if (AppData.RootImageFolder == null)
                    btnImagesFolderBrowse.PerformClick();
                else
                    txtRootImageFolder.Text = AppData.RootImageFolder;
                dgvCameras.AutoGenerateColumns = false;
                DgvCamerasDataRefresh();
                dgvDateDirs.AutoGenerateColumns = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                AppData.SaveAppData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (ex.Message.Contains("inner"))
                    MessageBox.Show(ex.InnerException.Message);
            }
        }

        private async void BtnDL1pic_Click(object sender, EventArgs e)
        {
            try
            {
                //var testUrl = "https://github.com/bvujovic/SurveillanceCam/blob/master/data/webcam.png?raw=true";
                var testUrl = "http://192.168.0.60/sdCardImg?img=/2021-08-21/03.46.36.jpg";
                await DownloadImageAsync(testUrl);
                Utils.ShowMbox("Kraj", "DownloadImageAsync()");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        /// <see cref="https://stackoverflow.com/questions/24797485/how-to-download-image-from-url"/>
        private async Task DownloadImageAsync(string url)
        {
            using (var client = new System.Net.WebClient())
            {
                await client.DownloadFileTaskAsync(new Uri(url), @"d:\Glavni\TempDownloads\test.jpg");
            }
        }

        private void BtnImagesFolderBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = new FolderBrowserDialog { RootFolder = Environment.SpecialFolder.MyComputer };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtRootImageFolder.Text = AppData.RootImageFolder = dialog.SelectedPath;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnRootImageFolderGoTo_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(AppData.RootImageFolder);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnNewCamera_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new FrmNewCamera();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var cam = new Camera
                    {
                        DeviceName = frm.DeviceName,
                        IpLastNum = frm.IpLastNum
                    };
                    //TODO ako se ovo ispitivanje uradi ranije mozda bi korisnik mogao
                    // da ostane na formi i ispravi podatak
                    if (AppData.Cameras.Any(it => it.IpLastNum == cam.IpLastNum))
                        throw new Exception("There is already a camera with given IP address.");
                    AppData.Cameras.Add(cam);
                    DgvCamerasDataRefresh();
                    using (var db = new Data.DbCtx())
                    {
                        db.Cameras.Add(cam);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnDelCamera_Click(object sender, EventArgs e)
        {
            try
            {
                if (Utils.ShowMboxYesNo("Are you sure?", "Remove Camera") != DialogResult.Yes)
                    return;
                using (var db = new Data.DbCtx())
                {
                    if (!(dgvCameras.CurrentRow?.DataBoundItem is Camera selCam))
                        return;
                    AppData.Cameras.Remove(selCam);
                    db.Cameras.Remove(selCam);
                    db.SaveChanges();
                }
                DgvCamerasDataRefresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void DgvCamerasDataRefresh()
        {
            dgvCameras.DataSource = null;
            dgvCameras.DataSource = AppData.Cameras;
        }

        private void DgvDateDirsDataRefresh()
        {
            dgvDateDirs.DataSource = null;
            dgvDateDirs.DataSource = AppData.DateDirs;
        }

        private void DgvCameras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selCam = dgvCameras.CurrentRow?.DataBoundItem as Camera;
            var frm = new FrmNewCamera(selCam.DeviceName, selCam.IpLastNum);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                using (var db = new Data.DbCtx())
                {
                    var cam = db.Cameras.Find(selCam.IdCam);
                    if (cam == null)
                        return;
                    selCam.DeviceName = cam.DeviceName = frm.DeviceName;
                    selCam.IpLastNum = cam.IpLastNum = frm.IpLastNum;
                    db.SaveChanges();
                }
                DgvCamerasDataRefresh();
            }
        }

        private IEnumerable<Camera> GetSelectedCameras()
        {
            if (dgvCameras.SelectedRows.Count == 0)
                return Enumerable.Empty<Camera>();

            var cams = new List<Camera>();
            foreach (DataGridViewRow row in dgvCameras.SelectedRows)
                cams.Add(row.DataBoundItem as Camera);
            return cams;
        }

        /// <summary>Uzimanje liste svih foldera/fajlova u folderu sa SD kartice.</summary>
        private string ListSdCard(DateTime? dt)
        {
            var cams = GetSelectedCameras();
            if (cams.Count() != 1)
                throw new Exception("Mora biti samo 1 kamera selektovana");

            if (TestData.IsEnabled)
                return dt.HasValue ? "" : TestData.ListSdCardDirs;

            var url = "http://" + cams.First().IpAddress + $"/listSdCard";
            if (dt.HasValue)
                url += $"?y={dt.Value.Year}&m={dt.Value.Month}&d={dt.Value.Day}";

            // https://stackoverflow.com/questions/27108264/how-to-properly-make-a-http-web-get-request
            var request = (HttpWebRequest)WebRequest.Create(url);
            using (var response = (HttpWebResponse)request.GetResponse())
            using (var stream = response.GetResponseStream())
            using (var reader = new System.IO.StreamReader(stream))
                return reader.ReadToEnd();
        }

        private void BtnGetDirs_Click(object sender, EventArgs e)
        {
            try
            {
                DateDir.Parse(GetSelectedCameras().First(), ListSdCard(null));
                DgvDateDirsDataRefresh();
                
            }
            catch (Exception ex) { Utils.ShowMbox(ex.Message, "Get Dirs"); }
        }

        private void BtnGetFiles_Click(object sender, EventArgs e)
        {
            try
            {
                txt.Text = ListSdCard(calendar.SelectionStart);
            }
            catch (Exception ex) { Utils.ShowMbox(ex.Message, "Get Files"); }
        }

        private void dgvDateDirs_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDateDirs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
