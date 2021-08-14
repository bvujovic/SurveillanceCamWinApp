
namespace SurveillanceCamWinApp
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            this.btnDL1pic = new System.Windows.Forms.Button();
            this.btnImagesFolderBrowse = new System.Windows.Forms.Button();
            this.txtRootImageFolder = new System.Windows.Forms.TextBox();
            this.btnRootImageFolderGoTo = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(120, 16);
            label1.TabIndex = 3;
            label1.Text = "Root Image Folder";
            // 
            // btnDL1pic
            // 
            this.btnDL1pic.Location = new System.Drawing.Point(12, 125);
            this.btnDL1pic.Name = "btnDL1pic";
            this.btnDL1pic.Size = new System.Drawing.Size(91, 34);
            this.btnDL1pic.TabIndex = 0;
            this.btnDL1pic.Text = "DL 1 pic";
            this.btnDL1pic.UseVisualStyleBackColor = true;
            this.btnDL1pic.Click += new System.EventHandler(this.BtnDL1pic_Click);
            // 
            // btnImagesFolderBrowse
            // 
            this.btnImagesFolderBrowse.Location = new System.Drawing.Point(390, 32);
            this.btnImagesFolderBrowse.Name = "btnImagesFolderBrowse";
            this.btnImagesFolderBrowse.Size = new System.Drawing.Size(75, 25);
            this.btnImagesFolderBrowse.TabIndex = 1;
            this.btnImagesFolderBrowse.Text = "Browse...";
            this.btnImagesFolderBrowse.UseVisualStyleBackColor = true;
            this.btnImagesFolderBrowse.Click += new System.EventHandler(this.BtnImagesFolderBrowse_Click);
            // 
            // txtRootImageFolder
            // 
            this.txtRootImageFolder.Location = new System.Drawing.Point(12, 33);
            this.txtRootImageFolder.Name = "txtRootImageFolder";
            this.txtRootImageFolder.ReadOnly = true;
            this.txtRootImageFolder.Size = new System.Drawing.Size(372, 22);
            this.txtRootImageFolder.TabIndex = 2;
            // 
            // btnRootImageFolderGoTo
            // 
            this.btnRootImageFolderGoTo.Location = new System.Drawing.Point(471, 33);
            this.btnRootImageFolderGoTo.Name = "btnRootImageFolderGoTo";
            this.btnRootImageFolderGoTo.Size = new System.Drawing.Size(75, 25);
            this.btnRootImageFolderGoTo.TabIndex = 4;
            this.btnRootImageFolderGoTo.Text = "Go To";
            this.btnRootImageFolderGoTo.UseVisualStyleBackColor = true;
            this.btnRootImageFolderGoTo.Click += new System.EventHandler(this.BtnRootImageFolderGoTo_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnRootImageFolderGoTo);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtRootImageFolder);
            this.Controls.Add(this.btnImagesFolderBrowse);
            this.Controls.Add(this.btnDL1pic);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = global::SurveillanceCamWinApp.Properties.Resources.webcam;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Surveillance Cam Win App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDL1pic;
        private System.Windows.Forms.Button btnImagesFolderBrowse;
        private System.Windows.Forms.TextBox txtRootImageFolder;
        private System.Windows.Forms.Button btnRootImageFolderGoTo;
    }
}

