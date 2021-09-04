using System;
using System.Collections.Generic;
using System.Linq;

namespace SurveillanceCamWinApp.Classes
{
    /// <summary>
    /// Podaci sa kojima se aplikacija moze testirati bez povezivanja sa ESP32CAM.
    /// </summary>
    public static class TestData
    {
        /// <summary>Da li je testiranje ukljuceno ili ne.</summary>
        public static bool IsEnabled { get; set; } = false;

        /// <summary>Test podaci za listanje root direktorijuma na SD kardici.</summary>
        /// <see cref="http://192.168.0.60/listSdCard"/>
        public static string ListSdCardDirs =>
@"/System Volume Information
/2021-08-06
/121-07-06
/2020-12-24
/2020-12-25
/2020-12-26
/2021-08-07
/2020-12-27
/2021-01-03
/2021-01-04
/2021-01-05
/2021-01-06
/2021-08-08
/2021-08-11
/1970-01-01
/2021-08-22
/2021-08-21
/2021-08-26
";

        /// <summary>Test podaci za listanje nekog direktorijuma na SD kardici.</summary>
        /// <see cref="http://192.168.0.60/listSdCard?y=2021&m=8&d=26"/>
        public static string ListSdCardFiles =>
@"/2021-08-26/05.27.15.jpg
/2021-08-26/05.27.30.jpg
/2021-08-26/05.27.46.jpg
/2021-08-26/05.28.02.jpg
/2021-08-26/05.28.18.jpg
/2021-08-26/05.28.34.jpg
/2021-08-26/05.28.50.jpg
";
    }
}
