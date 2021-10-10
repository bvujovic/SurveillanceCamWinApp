using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Windows.Forms;

namespace SurveillanceCamWinApp.F.ImagePreview
{
    /// <summary>
    /// Kontrola za odabir vremenskog intervala za koji ce se pregledati slike.
    /// </summary>
    public partial class UcTimeInterval : UserControl
    {
        public UcTimeInterval()
        {
            InitializeComponent();
        }

        private void UcTimeInterval_Load(object sender, EventArgs e)
        {
            // vremena se postavljaju na 00:00
            dtpTimeStart.Value = dtpTimeStart.MinDate;
            dtpTimeEnd.Value = dtpTimeEnd.MinDate;
        }

        /// <summary>Pocetak ili kraj intervala su se upravo promenili.</summary>
        public event EventHandler IntervalChanged;

        private void Dtp_ValueChanged(object sender, EventArgs e)
        {
            // poc i kraj su u razl. danima ako je poc vreme vece od krajnjeg vremena
            diffDays = tStart.Hour * 60 + tStart.Minute > tEnd.Hour * 60 + tEnd.Minute;
            IntervalChanged?.Invoke(sender, e);
        }
        
        /// <summary>Datum/vreme pocetka intervala.</summary>
        public DateTime IntervalStart
        {
            get
            {
                var d = dtpDate.Value;
                return new DateTime(d.Year, d.Month, d.Day
                    , tStart.Hour, tStart.Minute, tStart.Second);
            }
        }

        /// <summary>Da li su pocetak i kraj intervala u razl. danima.</summary>
        private bool diffDays = false;

        [SuppressMessage("Style", "IDE1006:Naming Styles")]
        private DateTime tStart => dtpTimeStart.Value;
        [SuppressMessage("Style", "IDE1006:Naming Styles")]
        private DateTime tEnd => dtpTimeEnd.Value;

        /// <summary>Datum/vreme kraja intervala.</summary>
        public DateTime IntervalEnd
        {
            get
            {
                var d = dtpDate.Value.AddDays(diffDays ? 1 : 0);
                return new DateTime(d.Year, d.Month, d.Day
                    , tEnd.Hour, tEnd.Minute, tEnd.Second);
            }
        }

        public void SetInterval(DateTime start, DateTime end)
        {
            dtpDate.Value = start.Date;
            dtpTimeStart.Value = start;
            dtpTimeEnd.Value = end;
        }

        //TODO mozda pored dtp-ova prikazati duzinu intervala u hh:mm
    }
}
