using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SurveillanceCamWinApp.Data.Models
{
    /// <summary>
    /// Podesavanje aplikacije. name/key -> value. value je tekstualna reprezentacija vrednosti datog kljuca.
    /// </summary>
    public class AppSetting
    {
        [Key]
        [Required]
        public string Name { get; set; }

        [Required]
        public string Value { get; set; }

        public AppSetting(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public override string ToString()
            => $"{Name}: {Value}";
    }
}
