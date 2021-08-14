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

namespace SurveillanceCamWinApp
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
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                AppData.SaveAppData();


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
    }
}
