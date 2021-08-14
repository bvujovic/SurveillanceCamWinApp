using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveillanceCamWinApp.Classes
{
    /// <summary>
    /// Globalni podaci za aplikaciju.
    /// </summary>
    public static class AppData
    {
        private static string rootImageFolder;

        public static string RootImageFolder
        {
            get { return rootImageFolder; }
            set { rootImageFolder = value; } //TODO ovde ubaciti neku validaciju i copy/move sadrzaja foldera
        }

    }
}
