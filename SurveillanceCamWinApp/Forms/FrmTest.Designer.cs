
namespace SurveillanceCamWinApp.Forms
{
    partial class FrmTest
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
            this.btnDlImage = new System.Windows.Forms.Button();
            this.btnDlRootDirs = new System.Windows.Forms.Button();
            this.btnDlDir = new System.Windows.Forms.Button();
            this.btnDlRootAndDir = new System.Windows.Forms.Button();
            this.btnDlImages = new System.Windows.Forms.Button();
            this.btnDlDateDir = new System.Windows.Forms.Button();
            this.chkInProgress = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDlImage
            // 
            this.btnDlImage.Location = new System.Drawing.Point(12, 296);
            this.btnDlImage.Name = "btnDlImage";
            this.btnDlImage.Size = new System.Drawing.Size(123, 39);
            this.btnDlImage.TabIndex = 0;
            this.btnDlImage.Text = "Start DL image";
            this.btnDlImage.UseVisualStyleBackColor = true;
            this.btnDlImage.Click += new System.EventHandler(this.BtnDlImage_Click);
            // 
            // btnDlRootDirs
            // 
            this.btnDlRootDirs.Location = new System.Drawing.Point(12, 108);
            this.btnDlRootDirs.Name = "btnDlRootDirs";
            this.btnDlRootDirs.Size = new System.Drawing.Size(190, 39);
            this.btnDlRootDirs.TabIndex = 1;
            this.btnDlRootDirs.Text = "Start DL root dirs";
            this.btnDlRootDirs.UseVisualStyleBackColor = true;
            this.btnDlRootDirs.Click += new System.EventHandler(this.BtnDlRootDirs_Click);
            // 
            // btnDlDir
            // 
            this.btnDlDir.Location = new System.Drawing.Point(12, 153);
            this.btnDlDir.Name = "btnDlDir";
            this.btnDlDir.Size = new System.Drawing.Size(190, 39);
            this.btnDlDir.TabIndex = 2;
            this.btnDlDir.Text = "Start DL 2021-08-26 dir";
            this.btnDlDir.UseVisualStyleBackColor = true;
            this.btnDlDir.Click += new System.EventHandler(this.BtnDlDir_Click);
            // 
            // btnDlRootAndDir
            // 
            this.btnDlRootAndDir.Location = new System.Drawing.Point(12, 198);
            this.btnDlRootAndDir.Name = "btnDlRootAndDir";
            this.btnDlRootAndDir.Size = new System.Drawing.Size(190, 39);
            this.btnDlRootAndDir.TabIndex = 3;
            this.btnDlRootAndDir.Text = "Start DL root && dir";
            this.btnDlRootAndDir.UseVisualStyleBackColor = true;
            this.btnDlRootAndDir.Click += new System.EventHandler(this.BtnDlRootAndDir_Click);
            // 
            // btnDlImages
            // 
            this.btnDlImages.Location = new System.Drawing.Point(12, 341);
            this.btnDlImages.Name = "btnDlImages";
            this.btnDlImages.Size = new System.Drawing.Size(123, 39);
            this.btnDlImages.TabIndex = 4;
            this.btnDlImages.Text = "Start DL images";
            this.btnDlImages.UseVisualStyleBackColor = true;
            this.btnDlImages.Click += new System.EventHandler(this.BtnDlImages_Click);
            // 
            // btnDlDateDir
            // 
            this.btnDlDateDir.Location = new System.Drawing.Point(12, 386);
            this.btnDlDateDir.Name = "btnDlDateDir";
            this.btnDlDateDir.Size = new System.Drawing.Size(123, 39);
            this.btnDlDateDir.TabIndex = 5;
            this.btnDlDateDir.Text = "Start DL dateDir";
            this.btnDlDateDir.UseVisualStyleBackColor = true;
            this.btnDlDateDir.Click += new System.EventHandler(this.BtnDlDateDir_Click);
            // 
            // chkInProgress
            // 
            this.chkInProgress.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkInProgress.AutoSize = true;
            this.chkInProgress.Location = new System.Drawing.Point(306, 268);
            this.chkInProgress.Name = "chkInProgress";
            this.chkInProgress.Size = new System.Drawing.Size(115, 28);
            this.chkInProgress.TabIndex = 6;
            this.chkInProgress.Text = "DL in progress";
            this.chkInProgress.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(359, 50);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 39);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save objects";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(359, 95);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(123, 39);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load objects";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 491);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkInProgress);
            this.Controls.Add(this.btnDlDateDir);
            this.Controls.Add(this.btnDlImages);
            this.Controls.Add(this.btnDlRootAndDir);
            this.Controls.Add(this.btnDlDir);
            this.Controls.Add(this.btnDlRootDirs);
            this.Controls.Add(this.btnDlImage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDlImage;
        private System.Windows.Forms.Button btnDlRootDirs;
        private System.Windows.Forms.Button btnDlDir;
        private System.Windows.Forms.Button btnDlRootAndDir;
        private System.Windows.Forms.Button btnDlImages;
        private System.Windows.Forms.Button btnDlDateDir;
        private System.Windows.Forms.CheckBox chkInProgress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
    }
}