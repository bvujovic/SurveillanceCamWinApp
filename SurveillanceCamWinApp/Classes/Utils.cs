using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveillanceCamWinApp.Classes
{
    public class Utils
    {
        /// <summary>Prikazuje modalni MessageBox.</summary>
        public static DialogResult ShowMbox(string message, string title)
        {
            return MessageBox.Show
            (
              message, title, MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }

        public static DialogResult ShowMbox(Exception ex, string title)
        {
            var msg = ex.Message;
            if (ex.InnerException != null)
                msg += Environment.NewLine + ex.InnerException.Message;
            
            return MessageBox.Show
            (
              msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error
            );
        }

        /// <summary>Prikazuje modalni MessageBox sa Yes/No pitanjem.</summary>
        public static DialogResult ShowMboxYesNo(string question, string title)
        {
            return MessageBox.Show
            (
                question, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );
        }

        public static void ClearControls(Control ctrl)
        {
            try
            {
                var n = ctrl.Controls.Count;
                if (n > 10)
                    ctrl.SuspendLayout();

                for (int i = ctrl.Controls.Count - 1; i >= 0; i--)
                    ctrl.Controls[i].Dispose();
                ctrl.Controls.Clear();

                if (n > 10)
                    ctrl.ResumeLayout();
            }
            catch (Exception ex) { Logger.AddToLog(ex); }
        }

        // https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1
        public const string VremeSamoSitnoFormat = "mm:ss.fff";
        public const string VremeKrupnoFormat = "HH:mm";
        public const string VremeFormat = "HH:mm:ss";
        public const string DatumFormat = "yyyy-MM-dd";
        public const string DatumVremeFormat = "yyyy-MM-dd HH:mm";
        public const string DatumVremeSveFormat = "yyyy-MM-dd HH:mm:ss.ff";

        /// <summary>Vraca trenutno vreme u SamoSitno formatu (min:sec.ms).</summary>
        public static string CurrentTimeMS
            => DateTime.Now.ToString(VremeSamoSitnoFormat);

        public static void GoToLink(string url)
        {
            try { System.Diagnostics.Process.Start("chrome.exe", url); }
            catch (Exception ex) { Logger.AddToLog(ex); }
        }
    }
}
