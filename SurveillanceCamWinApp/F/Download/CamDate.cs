using SurveillanceCamWinApp.Data.Models;
using System;

namespace SurveillanceCamWinApp.F.Download
{
    /// <summary>
    /// Agregat objekata Camera i DateTime? kreiran radi lakseg prenosa parametara i rezultata.
    /// </summary>
    public class CamDate
    {
        public CamDate(Camera cam, DateTime? dt)
        {
            Camera = cam;
            Date = dt;
        }

        public Camera Camera { get; private set; }
        public DateTime? Date { get; private set; }

        public override string ToString()
            => $"{Camera}, {(Date.HasValue ? Date.Value.ToString(Classes.Utils.DatumFormat) : "???")}";
    }
}
