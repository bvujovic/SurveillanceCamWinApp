using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveillanceCamWinApp.Data.Models
{
    /// <summary>
    /// Podesavanje aplikacije. 
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
