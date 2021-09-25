using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SurveillanceCamWinApp.Data.Models
{
    /// <summary>
    /// Slika napravljena ESP32CAM-om.
    /// </summary>
    public class ImageFile : IComparable<ImageFile>
    {
        public ImageFile()
        {
        }

        public ImageFile(DateDir dateDir, string name, bool existsOnSDC = true)
        {
            DateDir = dateDir;
            Name = name;
            ExistsOnSDC = existsOnSDC;
        }

        public static void Parse(DateDir dateDir, string resp)
        {
            if (string.IsNullOrEmpty(resp))
            {
                dateDir.ImgCountSDC = 0;
                return;
            }
            var lines = resp.Split(new string[] { Environment.NewLine, "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                // /2021-08-26/05.28.02.jpg
                var idx = line.LastIndexOf('/');
                if (idx == -1)
                    continue;
                var name = line.Substring(idx + 1);
                if (!dateDir.ImageFiles.Any(it => it.DateDir.Name == dateDir.Name && it.Name == name))
                    dateDir.ImageFiles.Add(new ImageFile(dateDir, name));
            }
            // ako je neka slika obrisana na kameri
            // ... mozda je treba izbaciti iz ImageFiles ako je nema ni lokalno???
            foreach (var img in dateDir.ImageFiles)
                if (!lines.Any(it => it.EndsWith(img.Name)))
                    img.ExistsOnSDC = false;
            dateDir.ImgCountSDC = dateDir.ImageFiles.Count(it => it.ExistsOnSDC.HasValue && it.ExistsOnSDC.Value);
        }

        [Key]
        public int IdImageFile { get; set; }

        [Required]
        public int DateDirId { get; set; }

        /// <summary>DateDir kojem pripada slika.</summary>
        public DateDir DateDir { get; set; }

        /// <summary>Naziv slike - vreme u formatu hh.mm.ss.jpg</summary>
        public string Name { get; set; }

        /// <summary>Puno ime slike/fajla na lokalnom drajvu.</summary>
        public string LocalImagePath
            => System.IO.Path.Combine(DateDir.LocalDirPath, Name);

        /// <summary>Da li slika postoji na SD kartici.</summary>
        public bool? ExistsOnSDC { get; set; }

        /// <summary>Da li slika postoji lokalnom drajvu.</summary>
        public bool ExistsLocally => System.IO.File.Exists(LocalImagePath);

        //B public bool CheckIfExistsLocally => System.IO.File.Exists(LocalImagePath);

        public override string ToString()
            => $"{Name}";

        public int CompareTo(ImageFile that)
        {
            if (that == null)
                return -1;
            return this.Name.CompareTo(that.Name);
        }
    }
}
