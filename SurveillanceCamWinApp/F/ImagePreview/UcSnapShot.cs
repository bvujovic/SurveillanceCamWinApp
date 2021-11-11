using SurveillanceCamWinApp.Classes;
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
                        Margin = new Padding(2), // kod okvira
                    };
                    pic.Click += Pic_Click;
                    var clh = (this.Width - 8) * pic.Image.Height / pic.Image.Width;
                    // -8 umesto -4 kod okvira
                    pic.Height = clh + 2;
                    Controls.Add(pic);

                    if (UcSnapShotPanel.MultiCamSelected)
                        Controls.Add(new Label
                        {
                            Text = imgf.DateDir.Camera.DeviceName,
                            Dock = DockStyle.Top,
                            TextAlign = ContentAlignment.BottomLeft
                        });
                }

                dateTime = imageFiles.First().DateTime;
                var fmt = dateTime.Second == 0 ? Utils.VremeKrupnoFormat : Utils.VremeFormat;
                lblTime.Text = dateTime.ToString(fmt);
                lblTime.SendToBack();

                // racunanje visine kontrole
                this.Height = Controls[0].Top + Controls[0].Height + 1 + 3; // +3 dodato kod okvira
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
            catch (Exception ex) { Logger.AddToLog(ex); }
        }
    }
}
