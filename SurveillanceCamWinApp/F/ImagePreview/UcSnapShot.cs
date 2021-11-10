using SurveillanceCamWinApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SurveillanceCamWinApp.F.ImagePreview
{
    public partial class UcSnapShot : UserControl
    {
        public UcSnapShot()
        {
            InitializeComponent();
        }

        private DateTime dateTime;

        public void SetImages(IEnumerable<ImageFile> imageFiles)
        {
            for (int i = Controls.Count - 1; i >= 0; i--)
                if (Controls[i].Name != lblTime.Name)
                    Controls[i].Dispose();
            //TODO bolje bi bilo da se ovo optimizuje tako da se ukinu samo one kontrole koje nisu potrebne

            if (imageFiles != null && imageFiles.Count() > 0) // ima slika
            {
                foreach (var imgf in imageFiles.Reverse())
                {
                    var pic = new PictureBox
                    {
                        Image = new Bitmap(imgf.LocalImagePath),
                        ImageLocation = imgf.LocalImagePath,
                        Cursor = Cursors.Hand,
                        Dock = DockStyle.Top,
                        SizeMode = PictureBoxSizeMode.Zoom,
                    };
                    pic.Click += Pic_Click;
                    var clh = (this.Width - 4) * pic.Image.Height / pic.Image.Width;
                    pic.Height = clh + 2;
                    Controls.Add(pic);

                    if (ImagePreviewOptions.MultiCamSelected)
                        Controls.Add(new Label
                        {
                            Text = imgf.DateDir.Camera.DeviceName,
                            Dock = DockStyle.Top,
                            TextAlign = ContentAlignment.BottomLeft
                        });
                }

                dateTime = imageFiles.First().DateTime;
                var fmt = dateTime.Second == 0 ? Classes.Utils.VremeKrupnoFormat : Classes.Utils.VremeFormat;
                lblTime.Text = dateTime.ToString(fmt);
                lblTime.SendToBack();

                // racunanje visine kontrole
                this.Height = Controls[0].Top + Controls[0].Height + 1;
            }
            else // nema slika - ovo ne bi ni trebalo da se desava
            {
                this.dateTime = DateTime.MinValue;
                lblTime.Text = "/";
            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            try
            {
                var pic = sender as PictureBox;
                System.Diagnostics.Process.Start(pic.ImageLocation);
            }
            catch (Exception ex) { Classes.Logger.AddToLog(ex); }
        }
    }
}
