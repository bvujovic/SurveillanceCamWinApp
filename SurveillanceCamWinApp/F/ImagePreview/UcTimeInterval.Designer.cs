
namespace SurveillanceCamWinApp.F.ImagePreview
{
    partial class UcTimeInterval
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label2;
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeEnd = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(204, 6);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(13, 16);
            label2.TabIndex = 3;
            label2.Text = "-";
            // 
            // dtpStartDate
            // 
            this.dtpDate.CustomFormat = "dd MMM yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(3, 3);
            this.dtpDate.Name = "dtpStartDate";
            this.dtpDate.Size = new System.Drawing.Size(114, 22);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            // 
            // dtpTimeStart
            // 
            this.dtpTimeStart.CustomFormat = "HH:mm";
            this.dtpTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeStart.Location = new System.Drawing.Point(141, 3);
            this.dtpTimeStart.Name = "dtpTimeStart";
            this.dtpTimeStart.ShowUpDown = true;
            this.dtpTimeStart.Size = new System.Drawing.Size(61, 22);
            this.dtpTimeStart.TabIndex = 2;
            this.dtpTimeStart.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            // 
            // dtpTimeEnd
            // 
            this.dtpTimeEnd.CustomFormat = "HH:mm";
            this.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeEnd.Location = new System.Drawing.Point(219, 3);
            this.dtpTimeEnd.Name = "dtpTimeEnd";
            this.dtpTimeEnd.ShowUpDown = true;
            this.dtpTimeEnd.Size = new System.Drawing.Size(61, 22);
            this.dtpTimeEnd.TabIndex = 4;
            this.dtpTimeEnd.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            // 
            // UcTimeInterval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpTimeEnd);
            this.Controls.Add(label2);
            this.Controls.Add(this.dtpTimeStart);
            this.Controls.Add(this.dtpDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcTimeInterval";
            this.Size = new System.Drawing.Size(284, 28);
            this.Load += new System.EventHandler(this.UcTimeInterval_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTimeStart;
        private System.Windows.Forms.DateTimePicker dtpTimeEnd;
    }
}
