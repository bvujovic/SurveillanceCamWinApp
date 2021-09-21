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

        private ImageFile imageFile;
        public ImageFile ImageFile
        {
            get { return imageFile; }
            set
            {
                imageFile = value;
                lbl.Text = value != null ? value.Name : "/";

                if (value != null && value.ExistsLocally)
                    try
                    {
                        pic.Image = new Bitmap(value.LocalImagePath); 
                    }
                    catch (Exception ex) { Classes.Logger.AddToLog(ex); }
                else
                    pic.Image = null;
            }
        }
    }
}
