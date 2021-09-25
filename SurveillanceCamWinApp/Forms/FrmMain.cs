using SurveillanceCamWinApp.Classes;
using SurveillanceCamWinApp.Data.Models;
using SurveillanceCamWinApp.F.Download;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
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
                dgvImages.AutoGenerateColumns = false;

                Downloader.Started += Downloader_Started;
                Downloader.Finished += Downloader_Finished;
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Loading Data..."); }
        }

        private void Downloader_Finished(object sender, EventArgs e)
        {
            lblDownloader.BackColor = this.BackColor;

        }

        private void Downloader_Started(object sender, EventArgs e)
        {
            lblDownloader.BackColor = Color.Green;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                AppData.SaveAppData();
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Saving Data..."); }
        }

        private void BtnDL1pic_Click(object sender, EventArgs e)
        {
            try
            {
                //var testUrl = "https://github.com/bvujovic/SurveillanceCam/blob/master/data/webcam.png?raw=true";
                //             http://192.168.0.60/sdCardImg?img=/2021-08-26/05.28.02.jpg
                //var testUrl = "http://192.168.0.60/sdCardImg?img=/2021-08-21/03.46.36.jpg";
                //await DownloadImageAsync(testUrl);
                //Utils.ShowMbox("Kraj", "DownloadImageAsync()");

                //Downloader.AddDownload(new CamDate(CurrentCamera, null));
                //F.Download.Downloader.AddDownload(GetCurrentDateDir());

                ucSnapShot1.ImageFile = CurrentImageFile;
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Test Download"); }
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
            catch (Exception ex) { Utils.ShowMbox(ex, "Set Root Image Folder"); }
        }

        private void BtnRootImageFolderGoTo_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(AppData.RootImageFolder);
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Show Image"); }
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
            catch (Exception ex) { Utils.ShowMbox(ex, "New Camera"); }
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
            catch (Exception ex) { Utils.ShowMbox(ex, "Delete Camera"); }
        }

        private void DgvCamerasDataRefresh()
        {
            dgvCameras.DataSource = null;
            dgvCameras.DataSource = AppData.Cameras;
        }

        private void DgvDateDirsDataRefresh()
        {
            dgvDateDirs.DataSource = null;
            var cam = CurrentCamera;
            if (cam != null)
            {
                cam.DateDirs.Sort();
                dgvDateDirs.DataSource = cam.DateDirs;
            }
        }

        private void DgvImagesDataRefresh()
        {
            dgvImages.DataSource = null;
            var dd = CurrentDateDir;
            if (dd != null)
            {
                dd.ImageFiles.Sort();
                dgvImages.DataSource = dd.ImageFiles;
            }
            //if (dgvDateDirs.CurrentRow?.DataBoundItem is DateDir dateDir)
            //    dgvImages.DataSource = dateDir.ImageFiles;
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

        private Camera CurrentCamera
            => dgvCameras.CurrentRow?.DataBoundItem as Camera;

        private DateDir CurrentDateDir
            => dgvDateDirs.CurrentRow?.DataBoundItem as DateDir;

        private ImageFile CurrentImageFile
            => dgvImages.CurrentRow?.DataBoundItem as ImageFile;

        private IEnumerable<Camera> GetSelectedCameras()
        {
            if (dgvCameras.SelectedRows.Count == 0)
                return Enumerable.Empty<Camera>();

            var cams = new List<Camera>();
            foreach (DataGridViewRow row in dgvCameras.SelectedRows)
                cams.Add(row.DataBoundItem as Camera);
            return cams;
        }

        //TODO primeniti ovu foru sa Cast i sl na GetSelectedCameras() ako ne bude nekih gresaka
        private IEnumerable<ImageFile> GetSelectedImages()
            => dgvImages.SelectedRows.Cast<DataGridViewRow>().Select(it => it.DataBoundItem)
                .Cast<ImageFile>();

        /// <summary>Uzimanje liste svih foldera/fajlova u folderu sa SD kartice.</summary>
        private string ListSdCard(DateTime? dt)
        {
            var cams = GetSelectedCameras();
            if (cams.Count() != 1)
                throw new Exception("Mora biti samo 1 kamera selektovana");

            if (TestData.IsEnabled)
                return dt.HasValue ? TestData.ListSdCardFiles : TestData.ListSdCardDirs;

            var url = "http://" + cams.First().IpAddress + $"/listSdCard";
            if (dt.HasValue)
                url += $"?y={dt.Value.Year}&m={dt.Value.Month}&d={dt.Value.Day}";

            // https://stackoverflow.com/questions/27108264/how-to-properly-make-a-http-web-get-request
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Timeout = 3000;
            using (var response = (HttpWebResponse)request.GetResponse())
            using (var stream = response.GetResponseStream())
            using (var reader = new System.IO.StreamReader(stream))
                return reader.ReadToEnd();
        }

        private void BtnGetDirs_Click(object sender, EventArgs e)
        {
            try
            {
                var resp = ListSdCard(null);
                DateDir.Parse(GetSelectedCameras().First(), resp);
                DgvDateDirsDataRefresh();
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Get Dirs"); }
        }

        private void BtnGetFiles_Click(object sender, EventArgs e)
        {
            try
            {
                var resp = ListSdCard(calendar.SelectionStart);
                ImageFile.Parse(CurrentDateDir, resp);
                DgvImagesDataRefresh();
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Get Files"); }
        }

        private void DgvCameras_SelectionChanged(object sender, EventArgs e)
        {
            dgvDateDirs.AutoGenerateColumns = false;
            DgvDateDirsDataRefresh();
        }

        private void DgvDateDirs_SelectionChanged(object sender, EventArgs e)
        {
            dgvImages.AutoGenerateColumns = false;
            DgvImagesDataRefresh();
        }

        private void DgvDateDirs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dd = CurrentDateDir;
            if (dd == null)
                return;
            if (e.ColumnIndex == dgvcDateDirsDL.Index)
                Downloader.AddDownload(dd);
            if (e.ColumnIndex == dgvcDateDirImgSDC.Index)
                Downloader.AddDownload(new CamDate(CurrentCamera, CurrentDateDir.Date));
            if (e.ColumnIndex == dgvcDateDirImgLocal.Index)
                CurrentDateDir.ImgCountLocal = CurrentDateDir.ImageFiles.Count(it => it.ExistsLocally);
        }

        private void DgvDateDirs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var dd = CurrentDateDir;
                if (dd != null)
                    System.Diagnostics.Process.Start(dd.LocalDirPath);
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Open Local Folder"); }
        }

        private void BtnDelDateDir_Click(object sender, EventArgs e)
        {
            try
            {
                var dd = CurrentDateDir;
                var cam = CurrentCamera;
                if (dd != null && cam != null)
                {
                    cam.DateDirs.Remove(dd);
                    DgvDateDirsDataRefresh();
                }
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Delete Date"); }
        }

        private void DgvImages_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var img = CurrentImageFile;
                if (img != null && img.ExistsLocally)
                    System.Diagnostics.Process.Start(img.LocalImagePath);
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Open Image"); }
        }

        private void DgvDateDirs_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
            => DgvDateDirs_RowCountChanged();

        private void DgvDateDirs_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
            => DgvDateDirs_RowCountChanged();

        private void DgvDateDirs_RowCountChanged()
            => lblDatesRowCount.Text = $"Dates Count: {dgvDateDirs.RowCount}";

        private void DgvImages_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
            => DgvImages_RowCountChanged();

        private void DgvImages_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
            => DgvImages_RowCountChanged();

        private void DgvImages_RowCountChanged()
            => lblImagesRowCount.Text = $"Images Count: {dgvImages.RowCount}";

        public static void DelImage(ImageFile img)
        {
            var dd = img.DateDir;
            var url = $"http://{dd.Camera.IpAddress}/delImg?img=/{dd.Name}/{img.Name}";
            WebRequest.Create(url).GetResponse();
        }

        public static void DelFolder(DateDir dd)
        {
            var url = $"http://{dd.Camera.IpAddress}/delFolder?folder={dd.Name}";
            WebRequest.Create(url).GetResponse();
        }

        private void CtxItemDelRemote_Click(object sender, EventArgs e)
        {
            var images = ctxMenu.SourceControl == dgvImages;
            if (Utils.ShowMboxYesNo("Are you sure?", "Remote Deletion") != DialogResult.Yes)
                return;
            try
            {
                if (images) // brisanje slika na kameri
                {
                    if (dgvImages.SelectedRows.Count == 0)
                        DelImage(CurrentImageFile);
                    else
                        foreach (var img in GetSelectedImages())
                            DelImage(img);
                }
                else // brisanje foldera na kameri
                {
                    DelFolder(CurrentDateDir);
                    foreach (var img in CurrentDateDir.ImageFiles)
                        img.ExistsOnSDC = false;
                }
                dgvImages.Refresh();
                dgvDateDirs.Refresh();
            }
            catch (Exception ex) { Utils.ShowMbox(ex, $"Delete {(images ? "Images" : "Folders")} On Cam"); }
        }

        private void CtxItemDelLocal_Click(object sender, EventArgs e)
        {
            var images = ctxMenu.SourceControl == dgvImages;
            if (Utils.ShowMboxYesNo("Are you sure?", "Local Deletion") != DialogResult.Yes)
                return;
            try
            {
                if (images) // brisanje slika lokalno
                {
                    if (dgvImages.SelectedRows.Count == 0)
                        System.IO.File.Delete(CurrentImageFile.LocalImagePath);
                    else
                        foreach (var img in GetSelectedImages())
                            System.IO.File.Delete(img.LocalImagePath);
                    CurrentDateDir.CalcImgCountLocal();
                    dgvImages.Refresh();
                }
                else // brisanje foldera lokalno
                {
                    System.IO.Directory.Delete(CurrentDateDir.LocalDirPath, true);
                }
                dgvDateDirs.Refresh();
            }
            catch (Exception ex) { Utils.ShowMbox(ex, $"Delete {(images ? "Images" : "Folders")} Locally"); }
        }

        private void CtxItemDelBoth_Click(object sender, EventArgs e)
        {
            // CurrentDateDir.ImageFiles.Remove(CurrentImageFile);

            var images = ctxMenu.SourceControl == dgvImages;
            if (Utils.ShowMboxYesNo("Are you sure?", "Local Deletion") != DialogResult.Yes)
                return;
            try
            {
                if (images) // brisanje slika potpuno
                {
                    if (dgvImages.SelectedRows.Count == 0)
                    {
                        System.IO.File.Delete(CurrentImageFile.LocalImagePath);
                        DelImage(CurrentImageFile);
                        CurrentDateDir.ImageFiles.Remove(CurrentImageFile);
                        DgvImagesDataRefresh();
                    }
                    else
                        foreach (var img in GetSelectedImages())
                        {
                            System.IO.File.Delete(img.LocalImagePath);
                            DelImage(img);
                            CurrentDateDir.ImageFiles.Remove(img);
                        }
                    CurrentDateDir.CalcImgCountLocal();
                    DgvImagesDataRefresh();
                    dgvImages.Refresh();
                }
                else // brisanje foldera potpuno
                {
                    var dd = CurrentDateDir;
                    System.IO.Directory.Delete(dd.LocalDirPath, true);
                    DelFolder(dd);
                    dd.Camera.DateDirs.Remove(dd);
                    DgvDateDirsDataRefresh();
                }
                dgvDateDirs.Refresh();
            }
            catch (Exception ex)
            {
                Utils.ShowMbox(ex, $"Delete {(images ? "Images" : "Folders")} Completely");
            }
        }
    }
}
