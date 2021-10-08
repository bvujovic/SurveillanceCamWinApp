using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveillanceCamWinApp.Controls
{
    public partial class UcStatusLabel : ToolStripStatusLabel
    {
        public UcStatusLabel()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.BackColor = this.Parent.BackColor;
        }

        private readonly Timer timer = new Timer() { Enabled = false, Interval = 1000 };

        public override string Text
        {
            get => base.Text;
            set
            {
                if (Text != "") // kontrola ne blinka pri postavljanju inicijalne vrednosti
                {
                    this.BackColor = Color.Orange;
                    timer.Start();
                }
                base.Text = value;
            }
        }
    }
}
