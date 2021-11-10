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
    /// <summary>
    /// Container kontrola koja sadrzi/prikazuje UcSnapShot-ove bazirana na FlowLayoutPanel-u.
    /// </summary>
    public partial class UcSnapShotPanel : FlowLayoutPanel
    {
        public UcSnapShotPanel()
        {
            InitializeComponent();
        }

        /// <summary>Postavljanje slika na panel koriscenjem UcSnapShot kontrola.</summary>
        public void SetImages(Dictionary<string, List<ImageFile>> ifs)
        {
            //? mozda za ifs==null uraditi clear panela ili to uraditi samo ako je kolekcija prazna
            if (ifs == null)
                throw new ArgumentNullException("ifs");

            //? upotrebiti ovo ako UserObjects uzmu da rastu Classes.Utils.ClearControls(this);
            Controls.Clear();
            foreach (var ss in ifs)
            {
                var uc = new UcSnapShot();
                uc.SetImages(ss.Value);
                Controls.Add(uc);
            }
        }
    }
}
