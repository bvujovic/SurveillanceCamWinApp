
namespace SurveillanceCamWinApp.Forms
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
            System.Windows.Forms.Label label2;
            this.btnDL1pic = new System.Windows.Forms.Button();
            this.btnImagesFolderBrowse = new System.Windows.Forms.Button();
            this.txtRootImageFolder = new System.Windows.Forms.TextBox();
            this.btnRootImageFolderGoTo = new System.Windows.Forms.Button();
            this.btnNewCamera = new System.Windows.Forms.Button();
            this.btnDelCamera = new System.Windows.Forms.Button();
            this.dgvCameras = new System.Windows.Forms.DataGridView();
            this.dgvcCamDeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCamIpAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCamLastImageDlStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.txt = new System.Windows.Forms.TextBox();
            this.btnGetDirs = new System.Windows.Forms.Button();
            this.btnGetFiles = new System.Windows.Forms.Button();
            this.dgvDateDirs = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvcDateDirName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDateDirImgSDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDateDirImgLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCameras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDateDirs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(510, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(159, 20);
            label1.TabIndex = 3;
            label1.Text = "Root Image Folder";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(12, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 20);
            label2.TabIndex = 9;
            label2.Text = "Cameras";
            // 
            // btnDL1pic
            // 
            this.btnDL1pic.Location = new System.Drawing.Point(646, 116);
            this.btnDL1pic.Name = "btnDL1pic";
            this.btnDL1pic.Size = new System.Drawing.Size(91, 34);
            this.btnDL1pic.TabIndex = 0;
            this.btnDL1pic.Text = "DL 1 pic";
            this.btnDL1pic.UseVisualStyleBackColor = true;
            this.btnDL1pic.Click += new System.EventHandler(this.BtnDL1pic_Click);
            // 
            // btnImagesFolderBrowse
            // 
            this.btnImagesFolderBrowse.Location = new System.Drawing.Point(888, 31);
            this.btnImagesFolderBrowse.Name = "btnImagesFolderBrowse";
            this.btnImagesFolderBrowse.Size = new System.Drawing.Size(75, 25);
            this.btnImagesFolderBrowse.TabIndex = 1;
            this.btnImagesFolderBrowse.Text = "Browse...";
            this.btnImagesFolderBrowse.UseVisualStyleBackColor = true;
            this.btnImagesFolderBrowse.Click += new System.EventHandler(this.BtnImagesFolderBrowse_Click);
            // 
            // txtRootImageFolder
            // 
            this.txtRootImageFolder.Location = new System.Drawing.Point(510, 32);
            this.txtRootImageFolder.Name = "txtRootImageFolder";
            this.txtRootImageFolder.ReadOnly = true;
            this.txtRootImageFolder.Size = new System.Drawing.Size(372, 22);
            this.txtRootImageFolder.TabIndex = 2;
            // 
            // btnRootImageFolderGoTo
            // 
            this.btnRootImageFolderGoTo.Location = new System.Drawing.Point(969, 32);
            this.btnRootImageFolderGoTo.Name = "btnRootImageFolderGoTo";
            this.btnRootImageFolderGoTo.Size = new System.Drawing.Size(75, 25);
            this.btnRootImageFolderGoTo.TabIndex = 4;
            this.btnRootImageFolderGoTo.Text = "Go To";
            this.btnRootImageFolderGoTo.UseVisualStyleBackColor = true;
            this.btnRootImageFolderGoTo.Click += new System.EventHandler(this.BtnRootImageFolderGoTo_Click);
            // 
            // btnNewCamera
            // 
            this.btnNewCamera.Location = new System.Drawing.Point(12, 186);
            this.btnNewCamera.Name = "btnNewCamera";
            this.btnNewCamera.Size = new System.Drawing.Size(75, 25);
            this.btnNewCamera.TabIndex = 5;
            this.btnNewCamera.Text = "New...";
            this.btnNewCamera.UseVisualStyleBackColor = true;
            this.btnNewCamera.Click += new System.EventHandler(this.BtnNewCamera_Click);
            // 
            // btnDelCamera
            // 
            this.btnDelCamera.Location = new System.Drawing.Point(93, 186);
            this.btnDelCamera.Name = "btnDelCamera";
            this.btnDelCamera.Size = new System.Drawing.Size(75, 25);
            this.btnDelCamera.TabIndex = 7;
            this.btnDelCamera.Text = "Delete";
            this.btnDelCamera.UseVisualStyleBackColor = true;
            this.btnDelCamera.Click += new System.EventHandler(this.BtnDelCamera_Click);
            // 
            // dgvCameras
            // 
            this.dgvCameras.AllowUserToAddRows = false;
            this.dgvCameras.AllowUserToDeleteRows = false;
            this.dgvCameras.BackgroundColor = System.Drawing.Color.White;
            this.dgvCameras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCameras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcCamDeviceName,
            this.dgvcCamIpAddress,
            this.dgvcCamLastImageDlStr});
            this.dgvCameras.Location = new System.Drawing.Point(12, 32);
            this.dgvCameras.Name = "dgvCameras";
            this.dgvCameras.ReadOnly = true;
            this.dgvCameras.RowHeadersWidth = 4;
            this.dgvCameras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCameras.Size = new System.Drawing.Size(443, 150);
            this.dgvCameras.TabIndex = 8;
            this.dgvCameras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCameras_CellDoubleClick);
            // 
            // dgvcCamDeviceName
            // 
            this.dgvcCamDeviceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcCamDeviceName.DataPropertyName = "DeviceName";
            this.dgvcCamDeviceName.HeaderText = "Device Name";
            this.dgvcCamDeviceName.Name = "dgvcCamDeviceName";
            this.dgvcCamDeviceName.ReadOnly = true;
            // 
            // dgvcCamIpAddress
            // 
            this.dgvcCamIpAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcCamIpAddress.DataPropertyName = "IPAddress";
            this.dgvcCamIpAddress.HeaderText = "IP Address";
            this.dgvcCamIpAddress.Name = "dgvcCamIpAddress";
            this.dgvcCamIpAddress.ReadOnly = true;
            // 
            // dgvcCamLastImageDlStr
            // 
            this.dgvcCamLastImageDlStr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcCamLastImageDlStr.DataPropertyName = "LastImageDlStr";
            this.dgvcCamLastImageDlStr.HeaderText = "Last Image DL";
            this.dgvcCamLastImageDlStr.Name = "dgvcCamLastImageDlStr";
            this.dgvcCamLastImageDlStr.ReadOnly = true;
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(12, 254);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 10;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(251, 254);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt.Size = new System.Drawing.Size(204, 162);
            this.txt.TabIndex = 11;
            // 
            // btnGetDirs
            // 
            this.btnGetDirs.Location = new System.Drawing.Point(251, 223);
            this.btnGetDirs.Name = "btnGetDirs";
            this.btnGetDirs.Size = new System.Drawing.Size(84, 25);
            this.btnGetDirs.TabIndex = 12;
            this.btnGetDirs.Text = "Get Dirs";
            this.btnGetDirs.UseVisualStyleBackColor = true;
            this.btnGetDirs.Click += new System.EventHandler(this.BtnGetDirs_Click);
            // 
            // btnGetFiles
            // 
            this.btnGetFiles.Location = new System.Drawing.Point(371, 223);
            this.btnGetFiles.Name = "btnGetFiles";
            this.btnGetFiles.Size = new System.Drawing.Size(84, 25);
            this.btnGetFiles.TabIndex = 13;
            this.btnGetFiles.Text = "Get Files";
            this.btnGetFiles.UseVisualStyleBackColor = true;
            this.btnGetFiles.Click += new System.EventHandler(this.BtnGetFiles_Click);
            // 
            // dgvDateDirs
            // 
            this.dgvDateDirs.AllowUserToAddRows = false;
            this.dgvDateDirs.AllowUserToDeleteRows = false;
            this.dgvDateDirs.BackgroundColor = System.Drawing.Color.White;
            this.dgvDateDirs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDateDirs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcDateDirName,
            this.dgvcDateDirImgSDC,
            this.dgvcDateDirImgLocal});
            this.dgvDateDirs.Location = new System.Drawing.Point(485, 254);
            this.dgvDateDirs.Name = "dgvDateDirs";
            this.dgvDateDirs.ReadOnly = true;
            this.dgvDateDirs.RowHeadersWidth = 4;
            this.dgvDateDirs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDateDirs.Size = new System.Drawing.Size(526, 185);
            this.dgvDateDirs.TabIndex = 14;
            this.dgvDateDirs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDateDirs_CellClick);
            this.dgvDateDirs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDateDirs_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(487, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dates";
            // 
            // dgvcDateDirName
            // 
            this.dgvcDateDirName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcDateDirName.DataPropertyName = "Name";
            this.dgvcDateDirName.HeaderText = "Date";
            this.dgvcDateDirName.Name = "dgvcDateDirName";
            this.dgvcDateDirName.ReadOnly = true;
            // 
            // dgvcDateDirImgSDC
            // 
            this.dgvcDateDirImgSDC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcDateDirImgSDC.DataPropertyName = "ImgCountSDC";
            this.dgvcDateDirImgSDC.HeaderText = "Images SDC";
            this.dgvcDateDirImgSDC.Name = "dgvcDateDirImgSDC";
            this.dgvcDateDirImgSDC.ReadOnly = true;
            // 
            // dgvcDateDirImgLocal
            // 
            this.dgvcDateDirImgLocal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcDateDirImgLocal.DataPropertyName = "ImgCountLocal";
            this.dgvcDateDirImgLocal.HeaderText = "Images Local";
            this.dgvcDateDirImgLocal.Name = "dgvcDateDirImgLocal";
            this.dgvcDateDirImgLocal.ReadOnly = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvDateDirs);
            this.Controls.Add(this.btnGetFiles);
            this.Controls.Add(this.btnGetDirs);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.dgvCameras);
            this.Controls.Add(this.btnDelCamera);
            this.Controls.Add(this.btnNewCamera);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCameras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDateDirs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDL1pic;
        private System.Windows.Forms.Button btnImagesFolderBrowse;
        private System.Windows.Forms.TextBox txtRootImageFolder;
        private System.Windows.Forms.Button btnRootImageFolderGoTo;
        private System.Windows.Forms.Button btnNewCamera;
        private System.Windows.Forms.Button btnDelCamera;
        private System.Windows.Forms.DataGridView dgvCameras;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCamDeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCamIpAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCamLastImageDlStr;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btnGetDirs;
        private System.Windows.Forms.Button btnGetFiles;
        private System.Windows.Forms.DataGridView dgvDateDirs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDateDirName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDateDirImgSDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDateDirImgLocal;
    }
}

