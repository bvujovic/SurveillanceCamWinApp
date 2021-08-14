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

        private async void BtnDL1pic_Click(object sender, EventArgs e)
        {
            try
            {
                var testUrl = "https://github.com/bvujovic/SurveillanceCam/blob/master/data/webcam.png?raw=true";
                await DownloadImageAsync(testUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    AppData.RootImageFolder = dialog.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
