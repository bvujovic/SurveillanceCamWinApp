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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.ToolStripStatusLabel lblStatusCaption;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnNewCamera = new System.Windows.Forms.Button();
            this.btnDelCamera = new System.Windows.Forms.Button();
            this.dgvCameras = new System.Windows.Forms.DataGridView();
            this.dgvcCamDeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCamIpAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCamLastImageDlStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGetDirs = new System.Windows.Forms.Button();
            this.btnGetImageFiles = new System.Windows.Forms.Button();
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
            this.lblDownloader = new System.Windows.Forms.Label();
            this.lblDatesRowCount = new System.Windows.Forms.Label();
            this.lblImagesRowCount = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.btnStatusesAll = new System.Windows.Forms.ToolStripSplitButton();
            this.lblStatus = new SurveillanceCamWinApp.Controls.UcStatusLabel();
            this.pnlSnapShots = new SurveillanceCamWinApp.F.ImagePreview.UcSnapShotPanel();
            this.ucTimeInterval = new SurveillanceCamWinApp.F.ImagePreview.UcTimeInterval();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.rootImageFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRootFolderSet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRootFolderOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlowDirection = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlowLeftRight = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlowTopBottom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWrapThumbnails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThumbnailBorders = new System.Windows.Forms.ToolStripMenuItem();
            label2 = new System.Windows.Forms.Label();
            lblStatusCaption = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCameras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDateDirs)).BeginInit();
            this.ctxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImages)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(10, 5);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 25);
            label2.TabIndex = 9;
            label2.Text = "Cameras";
            // 
            // lblStatusCaption
            // 
            lblStatusCaption.Name = "lblStatusCaption";
            lblStatusCaption.Size = new System.Drawing.Size(69, 17);
            lblStatusCaption.Text = "Last Status: ";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(3, 37);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(80, 36);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // btnNewCamera
            // 
            this.btnNewCamera.Location = new System.Drawing.Point(10, 154);
            this.btnNewCamera.Name = "btnNewCamera";
            this.btnNewCamera.Size = new System.Drawing.Size(66, 27);
            this.btnNewCamera.TabIndex = 5;
            this.btnNewCamera.Text = "New...";
            this.btnNewCamera.UseVisualStyleBackColor = true;
            this.btnNewCamera.Click += new System.EventHandler(this.BtnNewCamera_Click);
            // 
            // btnDelCamera
            // 
            this.btnDelCamera.Location = new System.Drawing.Point(81, 154);
            this.btnDelCamera.Name = "btnDelCamera";
            this.btnDelCamera.Size = new System.Drawing.Size(66, 27);
            this.btnDelCamera.TabIndex = 7;
            this.btnDelCamera.Text = "Delete";
            this.btnDelCamera.UseVisualStyleBackColor = true;
            this.btnDelCamera.Click += new System.EventHandler(this.BtnDelCamera_Click);
            // 
            // dgvCameras
            // 
            this.dgvCameras.AllowUserToAddRows = false;
            this.dgvCameras.AllowUserToDeleteRows = false;
            this.dgvCameras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCameras.BackgroundColor = System.Drawing.Color.White;
            this.dgvCameras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCameras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcCamDeviceName,
            this.dgvcCamIpAddress,
            this.dgvcCamLastImageDlStr});
            this.dgvCameras.Location = new System.Drawing.Point(10, 33);
            this.dgvCameras.Name = "dgvCameras";
            this.dgvCameras.ReadOnly = true;
            this.dgvCameras.RowHeadersWidth = 22;
            this.dgvCameras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCameras.Size = new System.Drawing.Size(411, 115);
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
            // btnGetDirs
            // 
            this.btnGetDirs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetDirs.Location = new System.Drawing.Point(347, 154);
            this.btnGetDirs.Name = "btnGetDirs";
            this.btnGetDirs.Size = new System.Drawing.Size(74, 27);
            this.btnGetDirs.TabIndex = 12;
            this.btnGetDirs.Text = "Get Dates";
            this.btnGetDirs.UseVisualStyleBackColor = true;
            this.btnGetDirs.Click += new System.EventHandler(this.BtnGetDirs_Click);
            // 
            // btnGetImageFiles
            // 
            this.btnGetImageFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetImageFiles.Location = new System.Drawing.Point(341, 385);
            this.btnGetImageFiles.Name = "btnGetImageFiles";
            this.btnGetImageFiles.Size = new System.Drawing.Size(80, 27);
            this.btnGetImageFiles.TabIndex = 13;
            this.btnGetImageFiles.Text = "Get Images";
            this.btnGetImageFiles.UseVisualStyleBackColor = true;
            this.btnGetImageFiles.Click += new System.EventHandler(this.BtnGetImageFiles_Click);
            // 
            // dgvDateDirs
            // 
            this.dgvDateDirs.AllowUserToAddRows = false;
            this.dgvDateDirs.AllowUserToDeleteRows = false;
            this.dgvDateDirs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDateDirs.BackgroundColor = System.Drawing.Color.White;
            this.dgvDateDirs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDateDirs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcDateDirName,
            this.dgvcDateDirImgSDC,
            this.dgvcDateDirImgLocal,
            this.dgvcDateDirsDL});
            this.dgvDateDirs.ContextMenuStrip = this.ctxMenu;
            this.dgvDateDirs.Location = new System.Drawing.Point(11, 220);
            this.dgvDateDirs.Name = "dgvDateDirs";
            this.dgvDateDirs.ReadOnly = true;
            this.dgvDateDirs.RowHeadersWidth = 22;
            this.dgvDateDirs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDateDirs.Size = new System.Drawing.Size(410, 159);
            this.dgvDateDirs.TabIndex = 14;
            this.dgvDateDirs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDateDirs_CellClick);
            this.dgvDateDirs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDateDirs_CellDoubleClick);
            this.dgvDateDirs.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvDateDirs_CellMouseUp);
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
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle41.NullValue = "?";
            this.dgvcDateDirImgSDC.DefaultCellStyle = dataGridViewCellStyle41;
            this.dgvcDateDirImgSDC.HeaderText = "CAM";
            this.dgvcDateDirImgSDC.Name = "dgvcDateDirImgSDC";
            this.dgvcDateDirImgSDC.ReadOnly = true;
            this.dgvcDateDirImgSDC.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcDateDirImgSDC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvcDateDirImgSDC.ToolTipText = "Number of images on ESP32CAM";
            this.dgvcDateDirImgSDC.Width = 42;
            // 
            // dgvcDateDirImgLocal
            // 
            this.dgvcDateDirImgLocal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvcDateDirImgLocal.DataPropertyName = "ImgCountLocal";
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle42.NullValue = "?";
            this.dgvcDateDirImgLocal.DefaultCellStyle = dataGridViewCellStyle42;
            this.dgvcDateDirImgLocal.HeaderText = "Local";
            this.dgvcDateDirImgLocal.Name = "dgvcDateDirImgLocal";
            this.dgvcDateDirImgLocal.ReadOnly = true;
            this.dgvcDateDirImgLocal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcDateDirImgLocal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvcDateDirImgLocal.ToolTipText = "Number of images on local drive";
            this.dgvcDateDirImgLocal.Width = 44;
            // 
            // dgvcDateDirsDL
            // 
            this.dgvcDateDirsDL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle43.NullValue = "ↆ";
            this.dgvcDateDirsDL.DefaultCellStyle = dataGridViewCellStyle43;
            this.dgvcDateDirsDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvcDateDirsDL.HeaderText = "DL";
            this.dgvcDateDirsDL.Name = "dgvcDateDirsDL";
            this.dgvcDateDirsDL.ReadOnly = true;
            this.dgvcDateDirsDL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcDateDirsDL.Text = "";
            this.dgvcDateDirsDL.ToolTipText = "Download all images for the date";
            this.dgvcDateDirsDL.Width = 29;
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
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dates";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Images";
            // 
            // dgvImages
            // 
            this.dgvImages.AllowUserToAddRows = false;
            this.dgvImages.AllowUserToDeleteRows = false;
            this.dgvImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvImages.BackgroundColor = System.Drawing.Color.White;
            this.dgvImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcImagesName,
            this.dgvcImagesExistsOnSDC,
            this.dgvcImagesExistsLocally,
            this.dgvcImagesDL});
            this.dgvImages.ContextMenuStrip = this.ctxMenu;
            this.dgvImages.Location = new System.Drawing.Point(10, 444);
            this.dgvImages.Name = "dgvImages";
            this.dgvImages.ReadOnly = true;
            this.dgvImages.RowHeadersWidth = 22;
            this.dgvImages.Size = new System.Drawing.Size(411, 203);
            this.dgvImages.TabIndex = 15;
            this.dgvImages.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvImages_CellClick);
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
            this.dgvcImagesExistsOnSDC.Width = 42;
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
            this.dgvcImagesExistsLocally.Width = 44;
            // 
            // dgvcImagesDL
            // 
            this.dgvcImagesDL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle44.NullValue = "ↆ";
            this.dgvcImagesDL.DefaultCellStyle = dataGridViewCellStyle44;
            this.dgvcImagesDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvcImagesDL.HeaderText = "DL";
            this.dgvcImagesDL.Name = "dgvcImagesDL";
            this.dgvcImagesDL.ReadOnly = true;
            this.dgvcImagesDL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcImagesDL.ToolTipText = "Download image";
            this.dgvcImagesDL.Width = 29;
            // 
            // lblDownloader
            // 
            this.lblDownloader.AutoSize = true;
            this.lblDownloader.Location = new System.Drawing.Point(4, 85);
            this.lblDownloader.Name = "lblDownloader";
            this.lblDownloader.Size = new System.Drawing.Size(79, 17);
            this.lblDownloader.TabIndex = 17;
            this.lblDownloader.Text = "Downloader";
            // 
            // lblDatesRowCount
            // 
            this.lblDatesRowCount.AutoSize = true;
            this.lblDatesRowCount.Location = new System.Drawing.Point(8, 385);
            this.lblDatesRowCount.Name = "lblDatesRowCount";
            this.lblDatesRowCount.Size = new System.Drawing.Size(91, 17);
            this.lblDatesRowCount.TabIndex = 18;
            this.lblDatesRowCount.Text = "Dates Count: /";
            // 
            // lblImagesRowCount
            // 
            this.lblImagesRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblImagesRowCount.AutoSize = true;
            this.lblImagesRowCount.Location = new System.Drawing.Point(11, 650);
            this.lblImagesRowCount.Name = "lblImagesRowCount";
            this.lblImagesRowCount.Size = new System.Drawing.Size(100, 17);
            this.lblImagesRowCount.TabIndex = 19;
            this.lblImagesRowCount.Text = "Images Count: /";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStatusesAll,
            lblStatusCaption,
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 674);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip.Size = new System.Drawing.Size(1074, 22);
            this.statusStrip.TabIndex = 22;
            this.statusStrip.Text = "statusStrip1";
            // 
            // btnStatusesAll
            // 
            this.btnStatusesAll.BackColor = System.Drawing.SystemColors.Control;
            this.btnStatusesAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStatusesAll.DropDownButtonWidth = 0;
            this.btnStatusesAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStatusesAll.Name = "btnStatusesAll";
            this.btnStatusesAll.Size = new System.Drawing.Size(72, 20);
            this.btnStatusesAll.Text = "All Statuses";
            this.btnStatusesAll.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnStatusesAll.ToolTipText = "Display All Statuses";
            this.btnStatusesAll.Visible = false;
            this.btnStatusesAll.Click += new System.EventHandler(this.BtnStatusesAll_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(12, 17);
            this.lblStatus.Text = "/";
            // 
            // pnlSnapShots
            // 
            this.pnlSnapShots.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSnapShots.AutoScroll = true;
            this.pnlSnapShots.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSnapShots.Location = new System.Drawing.Point(3, 191);
            this.pnlSnapShots.Name = "pnlSnapShots";
            this.pnlSnapShots.Size = new System.Drawing.Size(638, 476);
            this.pnlSnapShots.TabIndex = 23;
            this.pnlSnapShots.ThumbnailBorders = false;
            // 
            // ucTimeInterval
            // 
            this.ucTimeInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucTimeInterval.Location = new System.Drawing.Point(1, 154);
            this.ucTimeInterval.Margin = new System.Windows.Forms.Padding(4);
            this.ucTimeInterval.Name = "ucTimeInterval";
            this.ucTimeInterval.Size = new System.Drawing.Size(467, 30);
            this.ucTimeInterval.TabIndex = 20;
            this.ucTimeInterval.IntervalChanged += new System.EventHandler(this.UcTimeInterval_IntervalChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvDateDirs);
            this.splitContainer1.Panel1.Controls.Add(this.btnNewCamera);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelCamera);
            this.splitContainer1.Panel1.Controls.Add(this.dgvCameras);
            this.splitContainer1.Panel1.Controls.Add(label2);
            this.splitContainer1.Panel1.Controls.Add(this.lblImagesRowCount);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.lblDatesRowCount);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.btnGetDirs);
            this.splitContainer1.Panel1.Controls.Add(this.dgvImages);
            this.splitContainer1.Panel1.Controls.Add(this.btnGetImageFiles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnTest);
            this.splitContainer1.Panel2.Controls.Add(this.pnlSnapShots);
            this.splitContainer1.Panel2.Controls.Add(this.ucTimeInterval);
            this.splitContainer1.Panel2.Controls.Add(this.lblDownloader);
            this.splitContainer1.Panel2.Controls.Add(this.menuStrip);
            this.splitContainer1.Size = new System.Drawing.Size(1074, 674);
            this.splitContainer1.SplitterDistance = 427;
            this.splitContainer1.TabIndex = 24;
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiOptions});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(643, 28);
            this.menuStrip.TabIndex = 24;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rootImageFolderToolStripMenuItem});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(44, 24);
            this.tsmiFile.Text = "File";
            // 
            // rootImageFolderToolStripMenuItem
            // 
            this.rootImageFolderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRootFolderSet,
            this.tsmiRootFolderOpen});
            this.rootImageFolderToolStripMenuItem.Name = "rootImageFolderToolStripMenuItem";
            this.rootImageFolderToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.rootImageFolderToolStripMenuItem.Text = "Root Image Folder";
            // 
            // tsmiRootFolderSet
            // 
            this.tsmiRootFolderSet.Name = "tsmiRootFolderSet";
            this.tsmiRootFolderSet.Size = new System.Drawing.Size(169, 24);
            this.tsmiRootFolderSet.Text = "Set Location...";
            this.tsmiRootFolderSet.Click += new System.EventHandler(this.TsmiRootFolderSet_Click);
            // 
            // tsmiRootFolderOpen
            // 
            this.tsmiRootFolderOpen.Name = "tsmiRootFolderOpen";
            this.tsmiRootFolderOpen.Size = new System.Drawing.Size(169, 24);
            this.tsmiRootFolderOpen.Text = "Open...";
            this.tsmiRootFolderOpen.Click += new System.EventHandler(this.TsmiRootFolderOpen_Click);
            // 
            // tsmiOptions
            // 
            this.tsmiOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFlowDirection,
            this.tsmiWrapThumbnails,
            this.tsmiThumbnailBorders});
            this.tsmiOptions.Name = "tsmiOptions";
            this.tsmiOptions.Size = new System.Drawing.Size(73, 24);
            this.tsmiOptions.Text = "Options";
            // 
            // tsmiFlowDirection
            // 
            this.tsmiFlowDirection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFlowLeftRight,
            this.tsmiFlowTopBottom});
            this.tsmiFlowDirection.Name = "tsmiFlowDirection";
            this.tsmiFlowDirection.Size = new System.Drawing.Size(203, 24);
            this.tsmiFlowDirection.Text = "Flow Direction";
            // 
            // tsmiFlowLeftRight
            // 
            this.tsmiFlowLeftRight.Name = "tsmiFlowLeftRight";
            this.tsmiFlowLeftRight.Size = new System.Drawing.Size(175, 24);
            this.tsmiFlowLeftRight.Text = "Left to Right";
            this.tsmiFlowLeftRight.Click += new System.EventHandler(this.TsmiFlowLeftRight_Click);
            // 
            // tsmiFlowTopBottom
            // 
            this.tsmiFlowTopBottom.Name = "tsmiFlowTopBottom";
            this.tsmiFlowTopBottom.Size = new System.Drawing.Size(175, 24);
            this.tsmiFlowTopBottom.Text = "Top to Bottom";
            this.tsmiFlowTopBottom.Click += new System.EventHandler(this.TsmiFlowTopBottom_Click);
            // 
            // tsmiWrapThumbnails
            // 
            this.tsmiWrapThumbnails.CheckOnClick = true;
            this.tsmiWrapThumbnails.Name = "tsmiWrapThumbnails";
            this.tsmiWrapThumbnails.Size = new System.Drawing.Size(203, 24);
            this.tsmiWrapThumbnails.Text = "Wrap Thumbnails";
            this.tsmiWrapThumbnails.CheckedChanged += new System.EventHandler(this.TsmiWrapThumbnails_CheckedChanged);
            // 
            // tsmiThumbnailBorders
            // 
            this.tsmiThumbnailBorders.CheckOnClick = true;
            this.tsmiThumbnailBorders.Name = "tsmiThumbnailBorders";
            this.tsmiThumbnailBorders.Size = new System.Drawing.Size(203, 24);
            this.tsmiThumbnailBorders.Text = "Thumbnail Borders";
            this.tsmiThumbnailBorders.CheckedChanged += new System.EventHandler(this.TsmiThumbnailBorders_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 696);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = global::SurveillanceCamWinApp.Properties.Resources.webcam;
            this.MainMenuStrip = this.menuStrip;
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
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnNewCamera;
        private System.Windows.Forms.Button btnDelCamera;
        private System.Windows.Forms.DataGridView dgvCameras;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCamDeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCamIpAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCamLastImageDlStr;
        private System.Windows.Forms.Button btnGetDirs;
        private System.Windows.Forms.Button btnGetImageFiles;
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
        private System.Windows.Forms.Label lblDownloader;
        private System.Windows.Forms.Label lblDatesRowCount;
        private System.Windows.Forms.Label lblImagesRowCount;
        private F.ImagePreview.UcTimeInterval ucTimeInterval;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxItemDelRemote;
        private System.Windows.Forms.ToolStripMenuItem ctxItemDelLocal;
        private System.Windows.Forms.ToolStripMenuItem ctxItemDelBoth;
        private System.Windows.Forms.StatusStrip statusStrip;
        private Controls.UcStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripSplitButton btnStatusesAll;
        private F.ImagePreview.UcSnapShotPanel pnlSnapShots;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem rootImageFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiRootFolderSet;
        private System.Windows.Forms.ToolStripMenuItem tsmiRootFolderOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlowDirection;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlowLeftRight;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlowTopBottom;
        private System.Windows.Forms.ToolStripMenuItem tsmiWrapThumbnails;
        private System.Windows.Forms.ToolStripMenuItem tsmiThumbnailBorders;
    }
}

