using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SurveillanceCamWinApp.Forms
{
    public partial class FrmNewCamera : Form
    {
        public FrmNewCamera()
        {
            InitializeComponent();
        }

        public FrmNewCamera(string deviceName, int ipLastNum)
        {
            InitializeComponent();
            txtDeviceName.Text = deviceName;
            numIpLastNum.Value = ipLastNum;
        }

        public string DeviceName => txtDeviceName.Text;

        public int IpLastNum => (int)numIpLastNum.Value;
    }
}
