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
        public static bool IsEnabled { get; set; } = true;

        /// <summary></summary>
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
    }
}
