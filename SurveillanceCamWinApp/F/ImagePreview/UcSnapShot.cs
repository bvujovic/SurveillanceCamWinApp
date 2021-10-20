using SurveillanceCamWinApp.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private IEnumerable<ImageFile> imageFiles;

        public void SetImages(IEnumerable<ImageFile> imageFiles)
        {
            this.imageFiles = imageFiles;
            for (int i = Controls.Count - 1; i >= 0; i--)
                if (Controls[i].Name != lblTime.Name)
                    Controls[i].Dispose();
            //TODO bolje bi bilo da se ovo optimizuje tako da se ukinu samo one kontrole koje nisu potrebne

            if (imageFiles != null && imageFiles.Count() > 0) // ima slika
            {
                dateTime = imageFiles.First().DateTime;
                var fmt = dateTime.Second == 0 ? Classes.Utils.VremeKrupnoFormat : Classes.Utils.VremeFormat;
                lblTime.Text = dateTime.ToString(fmt);

                if (imageFiles.Count() == 1) // prikaz samo jedne slike
                {
                    var pic = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Dock = DockStyle.Top,
                        Image = new Bitmap(imageFiles.First().LocalImagePath),
                        //BorderStyle = BorderStyle.FixedSingle,
                    };
                    var clh = (this.Width - 4) * pic.Image.Height / pic.Image.Width;
                    pic.Height = clh + 2;
                    Controls.Add(pic);
                }
                else // ako ima vise slika za dato vreme
                {
                    foreach (var imgf in imageFiles)
                    {
                        this.Controls.Add(
                            new Label { Text = imgf.DateDir.Camera.DeviceName, Dock = DockStyle.Top });

                        //! kopija koda ozgo
                        var pic = new PictureBox
                        {
                            Image = new Bitmap(imageFiles.First().LocalImagePath),
                            Dock = DockStyle.Top,
                            SizeMode = PictureBoxSizeMode.Zoom,
                            //T BorderStyle = BorderStyle.FixedSingle,
                        };
                        var clh = (this.Width - 4) * pic.Image.Height / pic.Image.Width;
                        pic.Height = clh + 2;
                        Controls.Add(pic);
                    }
                }
                lblTime.SendToBack();
            }
            else // nema slika - ovo ne bi ni trebalo da se desava
            {
                this.dateTime = DateTime.MinValue;
                lblTime.Text = "/";
            }
        }

        //private ImageFile imageFile;
        //public ImageFile ImageFile
        //{
        //    get { return imageFile; }
        //    set
        //    {
        //        imageFile = value;
        //        lblTime.Text = value != null ? value.Name : "/";

        //        if (value != null && value.ExistsLocally)
        //            try
        //            {
        //                pic.Image = new Bitmap(value.LocalImagePath); 
        //            }
        //            catch (Exception ex) { Classes.Logger.AddToLog(ex); }
        //        else
        //            pic.Image = null;
        //    }
        //}
    }
}
