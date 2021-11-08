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
                AppData.LoadAppData();

                if (AppData.RootImageFolder == null)
                    btnImagesFolderBrowse.PerformClick();
                else
                    txtRootImageFolder.Text = AppData.RootImageFolder;
                dgvCameras.AutoGenerateColumns = false;
                DgvCamerasDataRefresh();
                dgvDateDirs.AutoGenerateColumns = false;
                dgvImages.AutoGenerateColumns = false;
                dgvCameras.RowHeadersWidth = dgvDateDirs.RowHeadersWidth = dgvImages.RowHeadersWidth = 30;

                Logger.AddedToLog += Logger_AddedToLog;
                Downloader.Started += Downloader_Started;
                Downloader.Finished += Downloader_Finished;
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Loading Data..."); }
        }

        private void Logger_AddedToLog(object sender, string e)
            => lblStatus.Text = e;

        private void Downloader_Finished(object sender, EventArgs e)
            => lblDownloader.BackColor = this.BackColor;

        private void Downloader_Started(object sender, EventArgs e)
            => lblDownloader.BackColor = Color.Green;

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { AppData.SaveAppData(); }
            catch (Exception ex) { Utils.ShowMbox(ex, "Saving Data..."); }
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            try
            {
                // kreiranje spiska ImageFiles za sel kamere i zadati interval
                var ifs = new Dictionary<string, List<ImageFile>>(); // ime slike => ImageFiles
                var date = ucTimeInterval.IntervalStart.Date;
                foreach (var cam in GetSelectedCameras().OrderBy(it => it.IdCam))
                    try
                    {
                        var dd = cam.GetDateDir(date);
                        if (dd != null)
                            foreach (var img in dd.ImageFiles)
                            {
                                if (ucTimeInterval.InInterval(img))
                                    if (!ifs.ContainsKey(img.Name))
                                        ifs.Add(img.Name, new List<ImageFile>() { img });
                                    else
                                        ifs[img.Name].Add(img);
                            }
                    }
                    catch (Exception ex) { Utils.ShowMbox(ex, btnTest.Text); }

                F.ImagePreview.ImageViewOptions.MultiCamSelected = GetSelectedCameras().Count() > 1;
                if (ifs.Count > 0)
                    ucSnapShot1.SetImages(ifs.First().Value);
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Test Download"); }
        }

        private void BtnImagesFolderBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = new FolderBrowserDialog { RootFolder = Environment.SpecialFolder.MyComputer };
                if (dialog.ShowDialog() == DialogResult.OK)
                    txtRootImageFolder.Text = AppData.RootImageFolder = dialog.SelectedPath;
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

        private void DgvDateDirsDataRefresh(bool saveCurrentPosition = false)
        {
            // datum tekuceg DateDir-a - MinValue ako se ne pamti
            var dtCur = (saveCurrentPosition && CurrentDateDir != null)
                ? CurrentDateDir.Date : DateTime.MinValue;

            dgvDateDirs.DataSource = null;
            var cam = CurrentCamera;
            if (cam != null)
            {
                cam.DateDirs.Sort();
                dgvDateDirs.DataSource = cam.DateDirs;
                if (dtCur != DateTime.MinValue) // ako je datum zapamcen...
                    foreach (DataGridViewRow row in dgvDateDirs.Rows)
                        if ((row.DataBoundItem as DateDir).Date == dtCur)
                        { // ... i nadjen za datu kameru, tekuci red se postavlja na taj datum
                            dgvDateDirs.CurrentCell = row.Cells[0];
                            break;
                        }
            }
        }

        private void DgvImagesDataRefresh()
        {
            dgvImages.DataSource = null;
            var dd = CurrentDateDir;
            // ovo sa Equals za kamere je sredjivanje pogresnog CurrentDateDir kad se promeni CurrentCamera
            //B if (dd != null && dd.Camera.Equals(CurrentCamera))
            if (IsCurrentDateDirValid)
            {
                dd.ImageFiles.Sort();
                dgvImages.DataSource = dd.ImageFiles;
            }
        }

        /// <summary>Uvek ce biti true, osim kada tekuca kamera nema nijedan DateDir.</summary>
        private bool IsCurrentDateDirValid
            => CurrentDateDir?.Camera != null && CurrentDateDir.Camera.Equals(CurrentCamera);

        private void DgvCameras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var cam = CurrentCamera;
                if (e.ColumnIndex == dgvcCamDeviceName.Index) // 2klik na ime kamere -> edit podataka
                {
                    var frm = new FrmNewCamera(cam.DeviceName, cam.IpLastNum);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        using (var db = new Data.DbCtx())
                        {
                            var c = db.Cameras.Find(cam.IdCam);
                            if (c == null)
                                return;
                            cam.DeviceName = c.DeviceName = frm.DeviceName;
                            cam.IpLastNum = c.IpLastNum = frm.IpLastNum;
                            db.SaveChanges();
                        }
                        DgvCamerasDataRefresh();
                    }
                }
                if (e.ColumnIndex == dgvcCamIpAddress.Index) // 2klik na IP adresu -> pokretanje web app
                    Utils.GoToLink($"http://{cam.IpAddress}");
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Camera"); }
        }

        private Camera CurrentCamera
            => dgvCameras.CurrentRow?.DataBoundItem as Camera;

        private DateDir CurrentDateDir
            => dgvDateDirs.CurrentRow?.DataBoundItem as DateDir;

        private ImageFile CurrentImageFile
            => dgvImages.CurrentRow?.DataBoundItem as ImageFile;

        //B
        //private IEnumerable<Camera> GetSelectedCameras()
        //{
        //    if (dgvCameras.SelectedRows.Count == 0)
        //        return Enumerable.Empty<Camera>();
        //    var cams = new List<Camera>();
        //    foreach (DataGridViewRow row in dgvCameras.SelectedRows)
        //        cams.Add(row.DataBoundItem as Camera);
        //    return cams;
        //}

        private IEnumerable<Camera> GetSelectedCameras()
            => dgvCameras.SelectedRows.Cast<DataGridViewRow>().Select(it => it.DataBoundItem)
                .Cast<Camera>();

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
            catch (Exception ex) { Logger.AddToLog("Get Dirs: " + ex.Message); }
        }

        private void BtnGetImageFiles_Click(object sender, EventArgs e)
        {
            try
            {
                //??? var resp = ListSdCard(calendar.SelectionStart);
                var resp = ListSdCard(CurrentDateDir.Date);
                ImageFile.Parse(CurrentDateDir, resp);
                DgvImagesDataRefresh();
            }
            catch (Exception ex) { Utils.ShowMbox(ex, btnGetImageFiles.Text); }
        }

        private void DgvCameras_SelectionChanged(object sender, EventArgs e)
        {
            dgvDateDirs.AutoGenerateColumns = false;
            DgvDateDirsDataRefresh(true);
        }

        private void DgvDateDirs_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgvImages.AutoGenerateColumns = false;
                DgvImagesDataRefresh();

                // postavljanje inicijalnog intervala za odabrane kamere i datum (DateDir)

                //HACK var cdd = dgvDateDirs.CurrentRow; uglavnom radi pri menjanju kamere, ali ne uvek
                var dgvRow = (dgvDateDirs.SelectedCells.Count > 0)
                    ? dgvDateDirs.Rows[dgvDateDirs.SelectedCells[0].RowIndex]
                    : dgvDateDirs.CurrentRow;
                if (dgvRow.DataBoundItem is DateDir cdd)
                {
                    // za sve sel. kamere pronaci vreme prve sliku od prvih i vreme poslednje od poslednjih slika
                    DateTime? dtMin = null;
                    DateTime? dtMax = null;
                    var date = cdd.Date;
                    foreach (var cam in GetSelectedCameras())
                    {
                        var dd = cam.GetDateDir(date);
                        if (dd == null)
                            continue;
                        var images = dd.ImageFiles.Where(it => it.ExistsLocally);
                        if (images.Count() > 0)
                        {
                            var dt = images.Min(it => it.DateTime);
                            if (!dtMin.HasValue || dt < dtMin.Value)
                                dtMin = dt;
                            dt = images.Max(it => it.DateTime);
                            if (!dtMax.HasValue || dt > dtMax.Value)
                                dtMax = dt;
                        }
                    }
                    if (dtMin.HasValue && dtMax.HasValue)
                        ucTimeInterval.SetInterval(dtMin.Value, dtMax.Value);
                    else
                        ucTimeInterval.SetInterval
                            (date, new DateTime(date.Year, date.Month, date.Day, 0, 0, 0));
                }
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "DateDirs - Selection Change"); }
        }

        private void UcTimeInterval_IntervalChanged(object sender, EventArgs e)
        {
        }

        private void DgvDateDirs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dd = CurrentDateDir;
            if (dd == null)
                return;
            if (e.ColumnIndex == dgvcDateDirsDL.Index) // DL svih slika za datum
                Downloader.AddDownload(dd);
            if (e.ColumnIndex == dgvcDateDirImgSDC.Index) // DL naziva slika za datum
                Downloader.AddDownload(new CamDate(CurrentCamera, dd.Date));
            if (e.ColumnIndex == dgvcDateDirImgLocal.Index) // refresh broja slika u lokalu
                //B dd.ImgCountLocal = dd.ImageFiles.Count(it => it.ExistsLocally);
                dd.CalcImgCountLocal();
        }

        private void DgvDateDirs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == -1 || e.ColumnIndex == 0) // 2klik na heder reda ili datum
                    if (CurrentDateDir != null)
                        System.Diagnostics.Process.Start(CurrentDateDir.LocalDirPath);
            }
            catch (Exception ex) { Utils.ShowMbox(ex, "Open Local Folder"); }
        }

        private void DgvImages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvcImagesDL.Index)
                Downloader.AddDownload(CurrentImageFile);
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

        #region BrisanjeSlika

        /// <summary>Brisanje slike/fajla na kameri.</summary>
        public static void CamDelImage(ImageFile img)
        {
            var dd = img.DateDir;
            var url = $"http://{dd.Camera.IpAddress}/delImg?img=/{dd.Name}/{img.Name}";
            WebRequest.Create(url).GetResponse();
        }

        /// <summary>Brisanje datuma/foldera na kameri.</summary>
        public static void CamDelFolder(DateDir dd)
        {
            var url = $"http://{dd.Camera.IpAddress}/delFolder?folder={dd.Name}";
            WebRequest.Create(url).GetResponse();
        }

        private void CtxItemDelRemote_Click(object sender, EventArgs e)
        {
            var areImages = ctxMenu.SourceControl == dgvImages;
            if (Utils.ShowMboxYesNo("Are you sure?", "Remote Deletion") != DialogResult.Yes)
                return;
            try
            {
                if (areImages) // brisanje slika na kameri
                {
                    if (dgvImages.SelectedRows.Count == 0)
                        CamDelImage(CurrentImageFile);
                    else
                        foreach (var img in GetSelectedImages())
                            CamDelImage(img);
                }
                else // brisanje foldera na kameri
                {
                    CamDelFolder(CurrentDateDir);
                    foreach (var img in CurrentDateDir.ImageFiles)
                        img.ExistsOnSDC = false;
                }
                dgvImages.Refresh();
                dgvDateDirs.Refresh();
            }
            catch (Exception ex) { Utils.ShowMbox(ex, $"Delete {(areImages ? "Images" : "Folders")} On Cam"); }
        }

        private void CtxItemDelLocal_Click(object sender, EventArgs e)
        {
            ///<summary>bris slika</summary>
            var delImages = ctxMenu.SourceControl == dgvImages;
            if (Utils.ShowMboxYesNo("Are you sure?", "Local Deletion") != DialogResult.Yes)
                return;
            try
            {
                if (delImages) // brisanje slika lokalno
                {
                    if (dgvImages.SelectedRows.Count == 0)
                        System.IO.File.Delete(CurrentImageFile.LocalImagePath);
                    else
                        foreach (var img in GetSelectedImages())
                            System.IO.File.Delete(img.LocalImagePath);
                    CurrentDateDir.CalcImgCountLocal();
                }
                else // brisanje foldera lokalno
                {
                    System.IO.Directory.Delete(CurrentDateDir.LocalDirPath, true);
                }

                dgvImages.Refresh();
                dgvDateDirs.Refresh();
            }
            catch (Exception ex) { Utils.ShowMbox(ex, $"Delete {(delImages ? "Images" : "Folders")} Locally"); }
        }

        private void CtxItemDelBoth_Click(object sender, EventArgs e)
        {
            var areImages = ctxMenu.SourceControl == dgvImages;
            if (Utils.ShowMboxYesNo("Are you sure?", "Local&Remote Deletion") != DialogResult.Yes)
                return;
            try
            {
                if (areImages) // brisanje slika potpuno
                {
                    if (dgvImages.SelectedRows.Count == 0)
                    {
                        System.IO.File.Delete(CurrentImageFile.LocalImagePath);
                        CamDelImage(CurrentImageFile);
                        CurrentDateDir.ImageFiles.Remove(CurrentImageFile);
                        //B DgvImagesDataRefresh();
                    }
                    else
                        foreach (var img in GetSelectedImages())
                        {
                            System.IO.File.Delete(img.LocalImagePath);
                            CamDelImage(img);
                            CurrentDateDir.ImageFiles.Remove(img);
                        }
                    CurrentDateDir.CalcImgCountLocal();
                    DgvImagesDataRefresh();
                    dgvImages.Refresh();
                }
                else // brisanje foldera potpuno
                {
                    var dd = CurrentDateDir;
                    if (System.IO.Directory.Exists(dd.LocalDirPath))
                        System.IO.Directory.Delete(dd.LocalDirPath, true);
                    CamDelFolder(dd);
                    dd.Camera.DateDirs.Remove(dd);
                    DgvDateDirsDataRefresh();
                }
                dgvDateDirs.Refresh();
            }
            catch (Exception ex)
            {
                Utils.ShowMbox(ex, $"Delete {(areImages ? "Images" : "Folders")} Completely");
            }
        }

        #endregion

        private void DgvDateDirs_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.ColumnIndex == 0)
            {
                // TODO bilo bi dobro da se red na koji sam desno-kliknuo selektuje
            }
        }

        private void BtnStatusesAll_Click(object sender, EventArgs e)
            => MessageBox.Show(string.Join(Environment.NewLine, Logger.Statuses), "All Statuses");
    }
}
