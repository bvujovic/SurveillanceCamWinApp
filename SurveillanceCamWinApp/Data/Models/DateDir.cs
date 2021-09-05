using SurveillanceCamWinApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SurveillanceCamWinApp.Data.Models
{
    /// <summary>
    /// Klasa ciji objekti predstavljaju direktorijum u kojem su slike napravljene jednog datuma.
    /// </summary>
    public class DateDir : IComparable<DateDir>
    {
        public DateDir()
        {
        }

        public DateDir(Camera cam, string name)
        {
            Camera = cam;
            Name = name;
            CalcImgCountLocal();
        }

        public static void Parse(Camera cam, string resp)
        {
            var lines = resp.Split(new string[] { Environment.NewLine, "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines.Where(it => !it.StartsWith("/System Volume")))
            {
                var name = line.Substring(1);
                if (!cam.DateDirs.Any(it => it.Camera.IdCam == cam.IdCam && it.Name == name))
                    cam.DateDirs.Add(new DateDir(cam, name));
            }
            cam.DateDirs.Sort();
        }

        public void CalcImgCountLocal()
        {
            ImgCountLocal = System.IO.Directory.Exists(LocalDirPath) ?
                System.IO.Directory.GetFiles(LocalDirPath).Length : 0;
        }

        [Key]
        public int IdDateDir { get; set; }

        [Required]
        public int CameraId { get; set; }

        /// <summary>Kamera za koju su vezane slike iz ovog foldera-datuma.</summary>
        public Camera Camera { get; set; }

        /// <summary>Naziv foldera - datum slika u formatu yyyy-mm-dd.</summary>
        public string Name { get; set; }

        //public DateTime Date => DateTime.Parse(Name);

        /// <summary>Broj slika na SD kartici.</summary>
        public int? ImgCountSDC { get; set; }

        /// <summary>Broj skinutih slika na racunaru.</summary>
        public int ImgCountLocal { get; set; }

        /// <summary>Puno ime foldera na lokalnom drajvu.</summary>
        public string LocalDirPath
            => System.IO.Path.Combine(AppData.RootImageFolder, Camera.DeviceName, Name);

        public List<ImageFile> ImageFiles { get; set; } = new List<ImageFile>();

        public override string ToString()
            => $"{Camera.DeviceName}/{Name}";

        public override bool Equals(object obj)
        {
            if (!(obj is DateDir that))
                return false;
            if (this.Camera == null || that.Camera == null)
                return false;
            return this.CameraId == that.CameraId && this.Name == that.Name;
        }

        public override int GetHashCode()
            => Name.GetHashCode() + CameraId;

        public int CompareTo(DateDir that)
        {
            if (that == null)
                return -1;
            return that.Name.CompareTo(this.Name);
        }
    }
}
