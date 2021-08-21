using SurveillanceCamWinApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                AppData.LoadAppData();

                if (AppData.RootImageFolder == null)
                    btnImagesFolderBrowse.PerformClick();
                else
                    txtRootImageFolder.Text = AppData.RootImageFolder;
                //B lstCameras.DataSource = AppData.Cameras;
                dgvCameras.AutoGenerateColumns = false;
                dgvCameras.DataSource = AppData.Cameras;
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
                var testUrl = "https://github.com/bvujovic/SurveillanceCam/blob/master/data/webcam.png?raw=true";
                await DownloadImageAsync(testUrl);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        /// <see cref="https://stackoverflow.com/questions/24797485/how-to-download-image-from-url"/>
        private async Task DownloadImageAsync(string url)
        {
            using (var client = new System.Net.WebClient())
            {
                await client.DownloadFileTaskAsync(new Uri(url), @"d:\Glavni\TempDownloads\test.png");
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
                    var cam = new Data.Models.Camera
                    {
                        DeviceName = frm.DeviceName,
                        IpLastNum = frm.IpLastNum
                    };
                    //TODO ako se ovo ispitivanje uradi ranije mozda bi korisnik mogao
                    // da ostane na formi i ispravi podatak
                    if (AppData.Cameras.Any(it => it.IpLastNum == cam.IpLastNum))
                        throw new Exception("There is already a camera with given IP address.");
                    AppData.Cameras.Add(cam);
                    dgvCameras.DataSource = null;
                    dgvCameras.DataSource = AppData.Cameras;
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
                    var selCam = dgvCameras.CurrentRow?.DataBoundItem as Data.Models.Camera;
                    if (selCam == null)
                        return;
                    AppData.Cameras.Remove(selCam);
                    db.Cameras.Remove(selCam);
                    db.SaveChanges();
                }
                dgvCameras.DataSource = null;
                dgvCameras.DataSource = AppData.Cameras;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void DgvCameras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selCam = dgvCameras.CurrentRow?.DataBoundItem as Data.Models.Camera;
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
                    //AppData.Cameras = db.Cameras.ToList();
                }
                dgvCameras.DataSource = null;
                dgvCameras.DataSource = AppData.Cameras;
            }
        }
    }
}
