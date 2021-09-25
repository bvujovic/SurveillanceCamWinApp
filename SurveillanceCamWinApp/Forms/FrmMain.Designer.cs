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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnGetDirs = new System.Windows.Forms.Button();
            this.btnGetFiles = new System.Windows.Forms.Button();
            this.dgvDateDirs = new System.Windows.Forms.DataGridView();
            this.dgvcDateDirName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDateDirImgSDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDateDirImgLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDateDirsDL = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxItemDelRemote = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxItemDelLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxItemDelBoth = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvImages = new System.Windows.Forms.DataGridView();
            this.dgvcImagesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcImagesExistsOnSDC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvcImagesExistsLocally = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvcImagesDL = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelDateDir = new System.Windows.Forms.Button();
            this.lblDownloader = new System.Windows.Forms.Label();
            this.lblDatesRowCount = new System.Windows.Forms.Label();
            this.lblImagesRowCount = new System.Windows.Forms.Label();
            this.ucSnapShot1 = new SurveillanceCamWinApp.F.ImagePreview.UcSnapShot();
            this.ucTimeInterval1 = new SurveillanceCamWinApp.F.ImagePreview.UcTimeInterval();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCameras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDateDirs)).BeginInit();
            this.ctxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImages)).BeginInit();
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
            this.btnDL1pic.Location = new System.Drawing.Point(872, 104);
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
            this.dgvCameras.SelectionChanged += new System.EventHandler(this.DgvCameras_SelectionChanged);
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
            this.calendar.Location = new System.Drawing.Point(510, 66);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 10;
            // 
            // btnGetDirs
            // 
            this.btnGetDirs.Location = new System.Drawing.Point(371, 186);
            this.btnGetDirs.Name = "btnGetDirs";
            this.btnGetDirs.Size = new System.Drawing.Size(84, 25);
            this.btnGetDirs.TabIndex = 12;
            this.btnGetDirs.Text = "Get Dates";
            this.btnGetDirs.UseVisualStyleBackColor = true;
            this.btnGetDirs.Click += new System.EventHandler(this.BtnGetDirs_Click);
            // 
            // btnGetFiles
            // 
            this.btnGetFiles.Location = new System.Drawing.Point(364, 440);
            this.btnGetFiles.Name = "btnGetFiles";
            this.btnGetFiles.Size = new System.Drawing.Size(91, 25);
            this.btnGetFiles.TabIndex = 13;
            this.btnGetFiles.Text = "Get Images";
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
            this.dgvcDateDirImgLocal,
            this.dgvcDateDirsDL});
            this.dgvDateDirs.ContextMenuStrip = this.ctxMenu;
            this.dgvDateDirs.Location = new System.Drawing.Point(12, 254);
            this.dgvDateDirs.Name = "dgvDateDirs";
            this.dgvDateDirs.ReadOnly = true;
            this.dgvDateDirs.RowHeadersWidth = 4;
            this.dgvDateDirs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDateDirs.Size = new System.Drawing.Size(443, 180);
            this.dgvDateDirs.TabIndex = 14;
            this.dgvDateDirs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDateDirs_CellClick);
            this.dgvDateDirs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDateDirs_CellDoubleClick);
            this.dgvDateDirs.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvDateDirs_RowsAdded);
            this.dgvDateDirs.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DgvDateDirs_RowsRemoved);
            this.dgvDateDirs.SelectionChanged += new System.EventHandler(this.DgvDateDirs_SelectionChanged);
            // 
            // dgvcDateDirName
            // 
            this.dgvcDateDirName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcDateDirName.DataPropertyName = "Name";
            this.dgvcDateDirName.HeaderText = "Date";
            this.dgvcDateDirName.Name = "dgvcDateDirName";
            this.dgvcDateDirName.ReadOnly = true;
            this.dgvcDateDirName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvcDateDirImgSDC
            // 
            this.dgvcDateDirImgSDC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvcDateDirImgSDC.DataPropertyName = "ImgCountSDC";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "?";
            this.dgvcDateDirImgSDC.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcDateDirImgSDC.HeaderText = "CAM";
            this.dgvcDateDirImgSDC.Name = "dgvcDateDirImgSDC";
            this.dgvcDateDirImgSDC.ReadOnly = true;
            this.dgvcDateDirImgSDC.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcDateDirImgSDC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvcDateDirImgSDC.ToolTipText = "Number of images on ESP32CAM";
            this.dgvcDateDirImgSDC.Width = 43;
            // 
            // dgvcDateDirImgLocal
            // 
            this.dgvcDateDirImgLocal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvcDateDirImgLocal.DataPropertyName = "ImgCountLocal";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "?";
            this.dgvcDateDirImgLocal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcDateDirImgLocal.HeaderText = "Local";
            this.dgvcDateDirImgLocal.Name = "dgvcDateDirImgLocal";
            this.dgvcDateDirImgLocal.ReadOnly = true;
            this.dgvcDateDirImgLocal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcDateDirImgLocal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvcDateDirImgLocal.ToolTipText = "Number of images on local drive";
            this.dgvcDateDirImgLocal.Width = 47;
            // 
            // dgvcDateDirsDL
            // 
            this.dgvcDateDirsDL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "ↆ";
            this.dgvcDateDirsDL.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcDateDirsDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvcDateDirsDL.HeaderText = "DL";
            this.dgvcDateDirsDL.Name = "dgvcDateDirsDL";
            this.dgvcDateDirsDL.ReadOnly = true;
            this.dgvcDateDirsDL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcDateDirsDL.Text = "";
            this.dgvcDateDirsDL.ToolTipText = "Download all images for the date";
            this.dgvcDateDirsDL.Width = 31;
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxItemDelRemote,
            this.ctxItemDelLocal,
            this.ctxItemDelBoth});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.ShowImageMargin = false;
            this.ctxMenu.Size = new System.Drawing.Size(130, 70);
            // 
            // ctxItemDelRemote
            // 
            this.ctxItemDelRemote.Name = "ctxItemDelRemote";
            this.ctxItemDelRemote.Size = new System.Drawing.Size(129, 22);
            this.ctxItemDelRemote.Text = "Delete On Cam";
            this.ctxItemDelRemote.Click += new System.EventHandler(this.CtxItemDelRemote_Click);
            // 
            // ctxItemDelLocal
            // 
            this.ctxItemDelLocal.Name = "ctxItemDelLocal";
            this.ctxItemDelLocal.Size = new System.Drawing.Size(129, 22);
            this.ctxItemDelLocal.Text = "Delete Locally";
            this.ctxItemDelLocal.Click += new System.EventHandler(this.CtxItemDelLocal_Click);
            // 
            // ctxItemDelBoth
            // 
            this.ctxItemDelBoth.Name = "ctxItemDelBoth";
            this.ctxItemDelBoth.Size = new System.Drawing.Size(129, 22);
            this.ctxItemDelBoth.Text = "Delete Both";
            this.ctxItemDelBoth.Click += new System.EventHandler(this.CtxItemDelBoth_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dates";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Images";
            // 
            // dgvImages
            // 
            this.dgvImages.AllowUserToAddRows = false;
            this.dgvImages.AllowUserToDeleteRows = false;
            this.dgvImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvImages.BackgroundColor = System.Drawing.Color.White;
            this.dgvImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcImagesName,
            this.dgvcImagesExistsOnSDC,
            this.dgvcImagesExistsLocally,
            this.dgvcImagesDL});
            this.dgvImages.ContextMenuStrip = this.ctxMenu;
            this.dgvImages.Location = new System.Drawing.Point(12, 489);
            this.dgvImages.Name = "dgvImages";
            this.dgvImages.ReadOnly = true;
            this.dgvImages.RowHeadersWidth = 22;
            this.dgvImages.Size = new System.Drawing.Size(443, 158);
            this.dgvImages.TabIndex = 15;
            this.dgvImages.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvImages_CellDoubleClick);
            this.dgvImages.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvImages_RowsAdded);
            this.dgvImages.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DgvImages_RowsRemoved);
            // 
            // dgvcImagesName
            // 
            this.dgvcImagesName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcImagesName.DataPropertyName = "Name";
            this.dgvcImagesName.HeaderText = "Name";
            this.dgvcImagesName.Name = "dgvcImagesName";
            this.dgvcImagesName.ReadOnly = true;
            // 
            // dgvcImagesExistsOnSDC
            // 
            this.dgvcImagesExistsOnSDC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvcImagesExistsOnSDC.DataPropertyName = "ExistsOnSDC";
            this.dgvcImagesExistsOnSDC.FalseValue = "false";
            this.dgvcImagesExistsOnSDC.HeaderText = "CAM";
            this.dgvcImagesExistsOnSDC.IndeterminateValue = "null";
            this.dgvcImagesExistsOnSDC.Name = "dgvcImagesExistsOnSDC";
            this.dgvcImagesExistsOnSDC.ReadOnly = true;
            this.dgvcImagesExistsOnSDC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcImagesExistsOnSDC.ToolTipText = "Exists on ESP32CAM";
            this.dgvcImagesExistsOnSDC.TrueValue = "true";
            this.dgvcImagesExistsOnSDC.Width = 43;
            // 
            // dgvcImagesExistsLocally
            // 
            this.dgvcImagesExistsLocally.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvcImagesExistsLocally.DataPropertyName = "ExistsLocally";
            this.dgvcImagesExistsLocally.HeaderText = "Local";
            this.dgvcImagesExistsLocally.Name = "dgvcImagesExistsLocally";
            this.dgvcImagesExistsLocally.ReadOnly = true;
            this.dgvcImagesExistsLocally.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcImagesExistsLocally.ToolTipText = "Exists locally";
            this.dgvcImagesExistsLocally.Width = 47;
            // 
            // dgvcImagesDL
            // 
            this.dgvcImagesDL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "ↆ";
            this.dgvcImagesDL.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvcImagesDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvcImagesDL.HeaderText = "DL";
            this.dgvcImagesDL.Name = "dgvcImagesDL";
            this.dgvcImagesDL.ReadOnly = true;
            this.dgvcImagesDL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcImagesDL.ToolTipText = "Download image";
            this.dgvcImagesDL.Width = 31;
            // 
            // btnDelDateDir
            // 
            this.btnDelDateDir.Location = new System.Drawing.Point(283, 440);
            this.btnDelDateDir.Name = "btnDelDateDir";
            this.btnDelDateDir.Size = new System.Drawing.Size(75, 25);
            this.btnDelDateDir.TabIndex = 16;
            this.btnDelDateDir.Text = "Delete";
            this.btnDelDateDir.UseVisualStyleBackColor = true;
            this.btnDelDateDir.Click += new System.EventHandler(this.BtnDelDateDir_Click);
            // 
            // lblDownloader
            // 
            this.lblDownloader.AutoSize = true;
            this.lblDownloader.Location = new System.Drawing.Point(843, 197);
            this.lblDownloader.Name = "lblDownloader";
            this.lblDownloader.Size = new System.Drawing.Size(81, 16);
            this.lblDownloader.TabIndex = 17;
            this.lblDownloader.Text = "Downloader";
            // 
            // lblDatesRowCount
            // 
            this.lblDatesRowCount.AutoSize = true;
            this.lblDatesRowCount.Location = new System.Drawing.Point(9, 440);
            this.lblDatesRowCount.Name = "lblDatesRowCount";
            this.lblDatesRowCount.Size = new System.Drawing.Size(91, 16);
            this.lblDatesRowCount.TabIndex = 18;
            this.lblDatesRowCount.Text = "Dates Count: /";
            // 
            // lblImagesRowCount
            // 
            this.lblImagesRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblImagesRowCount.AutoSize = true;
            this.lblImagesRowCount.Location = new System.Drawing.Point(12, 650);
            this.lblImagesRowCount.Name = "lblImagesRowCount";
            this.lblImagesRowCount.Size = new System.Drawing.Size(100, 16);
            this.lblImagesRowCount.TabIndex = 19;
            this.lblImagesRowCount.Text = "Images Count: /";
            // 
            // ucSnapShot1
            // 
            this.ucSnapShot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSnapShot1.ImageFile = null;
            this.ucSnapShot1.Location = new System.Drawing.Point(634, 389);
            this.ucSnapShot1.Margin = new System.Windows.Forms.Padding(4);
            this.ucSnapShot1.Name = "ucSnapShot1";
            this.ucSnapShot1.Size = new System.Drawing.Size(200, 185);
            this.ucSnapShot1.TabIndex = 21;
            // 
            // ucTimeInterval1
            // 
            this.ucTimeInterval1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucTimeInterval1.Location = new System.Drawing.Point(514, 254);
            this.ucTimeInterval1.Margin = new System.Windows.Forms.Padding(4);
            this.ucTimeInterval1.Name = "ucTimeInterval1";
            this.ucTimeInterval1.Size = new System.Drawing.Size(284, 28);
            this.ucTimeInterval1.TabIndex = 20;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 680);
            this.Controls.Add(this.ucSnapShot1);
            this.Controls.Add(this.ucTimeInterval1);
            this.Controls.Add(this.lblImagesRowCount);
            this.Controls.Add(this.lblDatesRowCount);
            this.Controls.Add(this.lblDownloader);
            this.Controls.Add(this.btnDelDateDir);
            this.Controls.Add(this.dgvImages);
            this.Controls.Add(this.dgvDateDirs);
            this.Controls.Add(this.btnGetFiles);
            this.Controls.Add(this.btnGetDirs);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.label4);
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
            this.ctxMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImages)).EndInit();
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
        private System.Windows.Forms.Button btnGetDirs;
        private System.Windows.Forms.Button btnGetFiles;
        private System.Windows.Forms.DataGridView dgvDateDirs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvImages;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDateDirName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDateDirImgSDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDateDirImgLocal;
        private System.Windows.Forms.DataGridViewButtonColumn dgvcDateDirsDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcImagesName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcImagesExistsOnSDC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcImagesExistsLocally;
        private System.Windows.Forms.DataGridViewButtonColumn dgvcImagesDL;
        private System.Windows.Forms.Button btnDelDateDir;
        private System.Windows.Forms.Label lblDownloader;
        private System.Windows.Forms.Label lblDatesRowCount;
        private System.Windows.Forms.Label lblImagesRowCount;
        private F.ImagePreview.UcTimeInterval ucTimeInterval1;
        private F.ImagePreview.UcSnapShot ucSnapShot1;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxItemDelRemote;
        private System.Windows.Forms.ToolStripMenuItem ctxItemDelLocal;
        private System.Windows.Forms.ToolStripMenuItem ctxItemDelBoth;
    }
}

