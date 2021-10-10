using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;

namespace SurveillanceCamWinApp.Data.Models
{
    /// <summary>
    /// Podaci o jednom ESP32CAM uredjaju.
    /// </summary>
    public class Camera
    {
        [Key]
        public int IdCam { get; set; }

        //B public string DeviceName { get; set; }
        private string deviceName;
        /// <summary>Naziv kamere.</summary>
        [Required]
        public string DeviceName
        {
            get { return deviceName; }
            set
            {
                var currPath = Path.Combine(Classes.AppData.RootImageFolder, deviceName);
                if (Directory.Exists(currPath))
                {
                    var newPath = Path.Combine(Classes.AppData.RootImageFolder, value);
                    if (Directory.Exists(newPath))
                        throw new Exception($"Directory '{newPath}' already exists.");
                    Directory.Move(currPath, newPath);
                }
                deviceName = value;
            }
        }

        /// <summary>Poslednji broj u IP adresi nekog lokalnog uredjaja.</summary>
        [Required]
        public int IpLastNum { get; set; }

        /// <summary>Prefiks (prva tri broja) u IP adresi za lokalne uredjaje.</summary>
        public const string IP_PREFIX = "192.168.0.";

        //TODO mozda bi IpAddress trebao da sadrzi i http:// prefiks
        /// <summary>Cela IP adresa kamere: IP_PREFIX + IpLastNum</summary>
        public string IpAddress => IP_PREFIX + IpLastNum;

        /// <summary>Datum/vreme poslednjeg DLa slika.</summary>
        public DateTime LastImageDL { get; set; }

        public string LastImageDlStr
            //TODO ovde mozda dodati if: ovaj (tekuci) datum -> samo vreme, u suprotnom -> datum i vreme
            => LastImageDL.Year == 1 ? "/" : LastImageDL.ToString(Classes.Utils.DatumVremeFormat);

        //TODO dodati mogucnost zadavanja redosleda kamera
        //* public int OrderIdx { get; set; }

        public List<DateDir> DateDirs { get; set; } = new List<DateDir>();
        //public ICollection<DateDir> DateDirs { get; set; }

        public DateDir GetDateDir(DateTime date)
            => DateDirs.FirstOrDefault(it => DateTime.Parse(it.Name) == date);

        public override string ToString()
            => $"{DeviceName} @ {IpAddress}";

        public override bool Equals(object obj)
        {
            if (!(obj is Camera that))
                return false;
            return this.IpLastNum == that.IpLastNum;
        }

        public override int GetHashCode()
            => IpLastNum;
    }
}
