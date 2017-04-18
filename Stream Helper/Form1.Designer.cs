namespace Stream_Helper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.appTitleLabel = new System.Windows.Forms.Label();
            this.filePathBox = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnStream = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.ipCombo = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ipLabel = new System.Windows.Forms.Label();
            this.selectFileLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.NumericUpDown();
            this.vBitrateBox = new System.Windows.Forms.NumericUpDown();
            this.vBitrateLabel = new System.Windows.Forms.Label();
            this.aBitrateLabel = new System.Windows.Forms.Label();
            this.aBitrateBox = new System.Windows.Forms.NumericUpDown();
            this.aSampleLabel = new System.Windows.Forms.Label();
            this.aSampleRateCombo = new System.Windows.Forms.ComboBox();
            this.streamUrlLabel = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.vHorizRes = new System.Windows.Forms.TextBox();
            this.vVertRes = new System.Windows.Forms.TextBox();
            this.vHorizResLabel = new System.Windows.Forms.Label();
            this.vVertResLabel = new System.Windows.Forms.Label();
            this.streamURLbox = new System.Windows.Forms.TextBox();
            this.vlcNotFoundLabel = new System.Windows.Forms.Label();
            this.step1Label = new System.Windows.Forms.Label();
            this.step2Label = new System.Windows.Forms.Label();
            this.step3Label = new System.Windows.Forms.Label();
            this.btnSourceFile = new System.Windows.Forms.Button();
            this.vFramerateBox = new System.Windows.Forms.NumericUpDown();
            this.vFramerateLabel = new System.Windows.Forms.Label();
            this.btnSourceDesktop = new System.Windows.Forms.Button();
            this.selectSourceLabel = new System.Windows.Forms.Label();
            this.aspectSelectLabel = new System.Windows.Forms.Label();
            this.aspect43Radio = new System.Windows.Forms.RadioButton();
            this.aspect169Radio = new System.Windows.Forms.RadioButton();
            this.picture169 = new System.Windows.Forms.PictureBox();
            this.picture43 = new System.Windows.Forms.PictureBox();
            this.note1Label = new System.Windows.Forms.Label();
            this.note1Text = new System.Windows.Forms.TextBox();
            this.dlExeLabel = new System.Windows.Forms.LinkLabel();
            this.dlZipLabel = new System.Windows.Forms.LinkLabel();
            this.dlScreenCapRecLabel = new System.Windows.Forms.LinkLabel();
            this.documentationLabel = new System.Windows.Forms.LinkLabel();
            this.bugReportLabel = new System.Windows.Forms.LinkLabel();
            this.contactLabel = new System.Windows.Forms.LinkLabel();
            this.scaleBox = new System.Windows.Forms.NumericUpDown();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.cachingMsBox = new System.Windows.Forms.NumericUpDown();
            this.cachingMsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBitrateBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBitrateBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFramerateBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture169)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachingMsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // appTitleLabel
            // 
            this.appTitleLabel.AutoSize = true;
            this.appTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitleLabel.ForeColor = System.Drawing.Color.LightGray;
            this.appTitleLabel.Location = new System.Drawing.Point(13, 13);
            this.appTitleLabel.Name = "appTitleLabel";
            this.appTitleLabel.Size = new System.Drawing.Size(203, 36);
            this.appTitleLabel.TabIndex = 1;
            this.appTitleLabel.Text = "Stream Helper";
            // 
            // filePathBox
            // 
            this.filePathBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathBox.Location = new System.Drawing.Point(35, 105);
            this.filePathBox.Name = "filePathBox";
            this.filePathBox.Size = new System.Drawing.Size(469, 23);
            this.filePathBox.TabIndex = 2;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Location = new System.Drawing.Point(510, 104);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 25);
            this.btnOpenFile.TabIndex = 3;
            this.btnOpenFile.Text = "Browse";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnStream
            // 
            this.btnStream.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStream.Location = new System.Drawing.Point(35, 361);
            this.btnStream.Name = "btnStream";
            this.btnStream.Size = new System.Drawing.Size(100, 26);
            this.btnStream.TabIndex = 4;
            this.btnStream.Text = "Start Stream";
            this.btnStream.UseVisualStyleBackColor = true;
            this.btnStream.Click += new System.EventHandler(this.btnStream_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Stream_Helper.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(563, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ipCombo
            // 
            this.ipCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipCombo.FormattingEnabled = true;
            this.ipCombo.Location = new System.Drawing.Point(35, 170);
            this.ipCombo.Name = "ipCombo";
            this.ipCombo.Size = new System.Drawing.Size(373, 24);
            this.ipCombo.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipLabel.ForeColor = System.Drawing.Color.Silver;
            this.ipLabel.Location = new System.Drawing.Point(32, 150);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(346, 17);
            this.ipLabel.TabIndex = 8;
            this.ipLabel.Text = "Select the ip address of your primary network adapter";
            // 
            // selectFileLabel
            // 
            this.selectFileLabel.AutoSize = true;
            this.selectFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFileLabel.ForeColor = System.Drawing.Color.LightGray;
            this.selectFileLabel.Location = new System.Drawing.Point(32, 85);
            this.selectFileLabel.Name = "selectFileLabel";
            this.selectFileLabel.Size = new System.Drawing.Size(182, 17);
            this.selectFileLabel.TabIndex = 9;
            this.selectFileLabel.Text = "Select a video file to stream";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLabel.ForeColor = System.Drawing.Color.LightGray;
            this.portLabel.Location = new System.Drawing.Point(411, 150);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(88, 17);
            this.portLabel.TabIndex = 11;
            this.portLabel.Text = "Select a port";
            // 
            // portBox
            // 
            this.portBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portBox.Location = new System.Drawing.Point(414, 171);
            this.portBox.Maximum = new decimal(new int[] {
            49151,
            0,
            0,
            0});
            this.portBox.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(85, 23);
            this.portBox.TabIndex = 12;
            this.portBox.Value = new decimal(new int[] {
            8080,
            0,
            0,
            0});
            // 
            // vBitrateBox
            // 
            this.vBitrateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vBitrateBox.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.vBitrateBox.Location = new System.Drawing.Point(35, 239);
            this.vBitrateBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.vBitrateBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.vBitrateBox.Name = "vBitrateBox";
            this.vBitrateBox.Size = new System.Drawing.Size(106, 23);
            this.vBitrateBox.TabIndex = 13;
            this.vBitrateBox.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // vBitrateLabel
            // 
            this.vBitrateLabel.AutoSize = true;
            this.vBitrateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vBitrateLabel.ForeColor = System.Drawing.Color.LightGray;
            this.vBitrateLabel.Location = new System.Drawing.Point(32, 219);
            this.vBitrateLabel.Name = "vBitrateLabel";
            this.vBitrateLabel.Size = new System.Drawing.Size(109, 15);
            this.vBitrateLabel.TabIndex = 14;
            this.vBitrateLabel.Text = "Video Bitrate (kb/s)";
            // 
            // aBitrateLabel
            // 
            this.aBitrateLabel.AutoSize = true;
            this.aBitrateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aBitrateLabel.ForeColor = System.Drawing.Color.LightGray;
            this.aBitrateLabel.Location = new System.Drawing.Point(32, 287);
            this.aBitrateLabel.Name = "aBitrateLabel";
            this.aBitrateLabel.Size = new System.Drawing.Size(109, 15);
            this.aBitrateLabel.TabIndex = 15;
            this.aBitrateLabel.Text = "Audio Bitrate (kb/s)";
            // 
            // aBitrateBox
            // 
            this.aBitrateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aBitrateBox.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.aBitrateBox.Location = new System.Drawing.Point(35, 308);
            this.aBitrateBox.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.aBitrateBox.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.aBitrateBox.Name = "aBitrateBox";
            this.aBitrateBox.Size = new System.Drawing.Size(106, 23);
            this.aBitrateBox.TabIndex = 16;
            this.aBitrateBox.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // aSampleLabel
            // 
            this.aSampleLabel.AutoSize = true;
            this.aSampleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aSampleLabel.ForeColor = System.Drawing.Color.LightGray;
            this.aSampleLabel.Location = new System.Drawing.Point(144, 287);
            this.aSampleLabel.Name = "aSampleLabel";
            this.aSampleLabel.Size = new System.Drawing.Size(139, 15);
            this.aSampleLabel.TabIndex = 17;
            this.aSampleLabel.Text = "Audio Sample Rate (Hz)";
            // 
            // aSampleRateCombo
            // 
            this.aSampleRateCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aSampleRateCombo.FormattingEnabled = true;
            this.aSampleRateCombo.Items.AddRange(new object[] {
            "8000",
            "11025",
            "22050",
            "44100",
            "48000"});
            this.aSampleRateCombo.Location = new System.Drawing.Point(147, 308);
            this.aSampleRateCombo.Name = "aSampleRateCombo";
            this.aSampleRateCombo.Size = new System.Drawing.Size(136, 24);
            this.aSampleRateCombo.TabIndex = 18;
            this.aSampleRateCombo.Text = "44100";
            // 
            // streamUrlLabel
            // 
            this.streamUrlLabel.AutoSize = true;
            this.streamUrlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streamUrlLabel.ForeColor = System.Drawing.Color.LightGray;
            this.streamUrlLabel.Location = new System.Drawing.Point(269, 389);
            this.streamUrlLabel.Name = "streamUrlLabel";
            this.streamUrlLabel.Size = new System.Drawing.Size(263, 20);
            this.streamUrlLabel.TabIndex = 19;
            this.streamUrlLabel.Text = "Open this URL in Home Theater VR";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(141, 361);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(61, 26);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Back";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // vHorizRes
            // 
            this.vHorizRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vHorizRes.Location = new System.Drawing.Point(185, 343);
            this.vHorizRes.Name = "vHorizRes";
            this.vHorizRes.Size = new System.Drawing.Size(208, 23);
            this.vHorizRes.TabIndex = 21;
            this.vHorizRes.Text = "Auto";
            // 
            // vVertRes
            // 
            this.vVertRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vVertRes.Location = new System.Drawing.Point(399, 343);
            this.vVertRes.Name = "vVertRes";
            this.vVertRes.Size = new System.Drawing.Size(191, 23);
            this.vVertRes.TabIndex = 22;
            this.vVertRes.Text = "Auto";
            // 
            // vHorizResLabel
            // 
            this.vHorizResLabel.AutoSize = true;
            this.vHorizResLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vHorizResLabel.ForeColor = System.Drawing.Color.LightGray;
            this.vHorizResLabel.Location = new System.Drawing.Point(186, 323);
            this.vHorizResLabel.Name = "vHorizResLabel";
            this.vHorizResLabel.Size = new System.Drawing.Size(211, 17);
            this.vHorizResLabel.TabIndex = 23;
            this.vHorizResLabel.Text = "Video Horizontal Resolution (px)";
            // 
            // vVertResLabel
            // 
            this.vVertResLabel.AutoSize = true;
            this.vVertResLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vVertResLabel.ForeColor = System.Drawing.Color.LightGray;
            this.vVertResLabel.Location = new System.Drawing.Point(396, 323);
            this.vVertResLabel.Name = "vVertResLabel";
            this.vVertResLabel.Size = new System.Drawing.Size(194, 17);
            this.vVertResLabel.TabIndex = 24;
            this.vVertResLabel.Text = "Video Vertical Resolution (px)";
            // 
            // streamURLbox
            // 
            this.streamURLbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.streamURLbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streamURLbox.ForeColor = System.Drawing.Color.LightGray;
            this.streamURLbox.Location = new System.Drawing.Point(225, 412);
            this.streamURLbox.Name = "streamURLbox";
            this.streamURLbox.Size = new System.Drawing.Size(359, 32);
            this.streamURLbox.TabIndex = 26;
            this.streamURLbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vlcNotFoundLabel
            // 
            this.vlcNotFoundLabel.AutoSize = true;
            this.vlcNotFoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vlcNotFoundLabel.ForeColor = System.Drawing.Color.Red;
            this.vlcNotFoundLabel.Location = new System.Drawing.Point(22, 53);
            this.vlcNotFoundLabel.Name = "vlcNotFoundLabel";
            this.vlcNotFoundLabel.Size = new System.Drawing.Size(127, 17);
            this.vlcNotFoundLabel.TabIndex = 28;
            this.vlcNotFoundLabel.Text = "Cannot find vlc.exe";
            // 
            // step1Label
            // 
            this.step1Label.AutoSize = true;
            this.step1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step1Label.ForeColor = System.Drawing.Color.Lime;
            this.step1Label.Location = new System.Drawing.Point(9, 108);
            this.step1Label.Name = "step1Label";
            this.step1Label.Size = new System.Drawing.Size(20, 17);
            this.step1Label.TabIndex = 29;
            this.step1Label.Text = "1.";
            // 
            // step2Label
            // 
            this.step2Label.AutoSize = true;
            this.step2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step2Label.ForeColor = System.Drawing.Color.Lime;
            this.step2Label.Location = new System.Drawing.Point(9, 173);
            this.step2Label.Name = "step2Label";
            this.step2Label.Size = new System.Drawing.Size(20, 17);
            this.step2Label.TabIndex = 30;
            this.step2Label.Text = "2.";
            // 
            // step3Label
            // 
            this.step3Label.AutoSize = true;
            this.step3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step3Label.ForeColor = System.Drawing.Color.Lime;
            this.step3Label.Location = new System.Drawing.Point(9, 366);
            this.step3Label.Name = "step3Label";
            this.step3Label.Size = new System.Drawing.Size(20, 17);
            this.step3Label.TabIndex = 31;
            this.step3Label.Text = "3.";
            // 
            // btnSourceFile
            // 
            this.btnSourceFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSourceFile.Location = new System.Drawing.Point(146, 113);
            this.btnSourceFile.Name = "btnSourceFile";
            this.btnSourceFile.Size = new System.Drawing.Size(149, 27);
            this.btnSourceFile.TabIndex = 32;
            this.btnSourceFile.Text = "Video file";
            this.btnSourceFile.UseVisualStyleBackColor = true;
            this.btnSourceFile.Click += new System.EventHandler(this.btnSourceFile_Click);
            // 
            // vFramerateBox
            // 
            this.vFramerateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vFramerateBox.Location = new System.Drawing.Point(147, 239);
            this.vFramerateBox.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.vFramerateBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.vFramerateBox.Name = "vFramerateBox";
            this.vFramerateBox.Size = new System.Drawing.Size(130, 23);
            this.vFramerateBox.TabIndex = 33;
            this.vFramerateBox.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // vFramerateLabel
            // 
            this.vFramerateLabel.AutoSize = true;
            this.vFramerateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vFramerateLabel.ForeColor = System.Drawing.Color.LightGray;
            this.vFramerateLabel.Location = new System.Drawing.Point(147, 219);
            this.vFramerateLabel.Name = "vFramerateLabel";
            this.vFramerateLabel.Size = new System.Drawing.Size(132, 15);
            this.vFramerateLabel.TabIndex = 34;
            this.vFramerateLabel.Text = "Video Framerate (FPS)";
            // 
            // btnSourceDesktop
            // 
            this.btnSourceDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSourceDesktop.Location = new System.Drawing.Point(301, 113);
            this.btnSourceDesktop.Name = "btnSourceDesktop";
            this.btnSourceDesktop.Size = new System.Drawing.Size(150, 27);
            this.btnSourceDesktop.TabIndex = 35;
            this.btnSourceDesktop.Text = "Windows desktop";
            this.btnSourceDesktop.UseVisualStyleBackColor = true;
            this.btnSourceDesktop.Click += new System.EventHandler(this.btnSourceDesktop_Click);
            // 
            // selectSourceLabel
            // 
            this.selectSourceLabel.AutoSize = true;
            this.selectSourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSourceLabel.ForeColor = System.Drawing.Color.LightGray;
            this.selectSourceLabel.Location = new System.Drawing.Point(167, 80);
            this.selectSourceLabel.Name = "selectSourceLabel";
            this.selectSourceLabel.Size = new System.Drawing.Size(265, 25);
            this.selectSourceLabel.TabIndex = 36;
            this.selectSourceLabel.Text = "What do you want to stream?";
            // 
            // aspectSelectLabel
            // 
            this.aspectSelectLabel.AutoSize = true;
            this.aspectSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aspectSelectLabel.ForeColor = System.Drawing.Color.LightGray;
            this.aspectSelectLabel.Location = new System.Drawing.Point(32, 108);
            this.aspectSelectLabel.Name = "aspectSelectLabel";
            this.aspectSelectLabel.Size = new System.Drawing.Size(204, 17);
            this.aspectSelectLabel.TabIndex = 37;
            this.aspectSelectLabel.Text = "Select your screen aspect ratio";
            // 
            // aspect43Radio
            // 
            this.aspect43Radio.AutoSize = true;
            this.aspect43Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aspect43Radio.ForeColor = System.Drawing.Color.LightGray;
            this.aspect43Radio.Location = new System.Drawing.Point(431, 108);
            this.aspect43Radio.Name = "aspect43Radio";
            this.aspect43Radio.Size = new System.Drawing.Size(46, 21);
            this.aspect43Radio.TabIndex = 40;
            this.aspect43Radio.Text = "4:3";
            this.aspect43Radio.UseVisualStyleBackColor = true;
            // 
            // aspect169Radio
            // 
            this.aspect169Radio.AutoSize = true;
            this.aspect169Radio.Checked = true;
            this.aspect169Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aspect169Radio.ForeColor = System.Drawing.Color.LightGray;
            this.aspect169Radio.Location = new System.Drawing.Point(265, 106);
            this.aspect169Radio.Name = "aspect169Radio";
            this.aspect169Radio.Size = new System.Drawing.Size(54, 21);
            this.aspect169Radio.TabIndex = 41;
            this.aspect169Radio.TabStop = true;
            this.aspect169Radio.Text = "16:9";
            this.aspect169Radio.UseVisualStyleBackColor = true;
            // 
            // picture169
            // 
            this.picture169.BackColor = System.Drawing.Color.DimGray;
            this.picture169.Location = new System.Drawing.Point(322, 94);
            this.picture169.Name = "picture169";
            this.picture169.Size = new System.Drawing.Size(80, 45);
            this.picture169.TabIndex = 42;
            this.picture169.TabStop = false;
            // 
            // picture43
            // 
            this.picture43.BackColor = System.Drawing.Color.DimGray;
            this.picture43.Location = new System.Drawing.Point(480, 94);
            this.picture43.Name = "picture43";
            this.picture43.Size = new System.Drawing.Size(60, 45);
            this.picture43.TabIndex = 43;
            this.picture43.TabStop = false;
            // 
            // note1Label
            // 
            this.note1Label.AutoSize = true;
            this.note1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note1Label.ForeColor = System.Drawing.Color.Gray;
            this.note1Label.Location = new System.Drawing.Point(28, 168);
            this.note1Label.Name = "note1Label";
            this.note1Label.Size = new System.Drawing.Size(55, 20);
            this.note1Label.TabIndex = 44;
            this.note1Label.Text = "Notes:";
            // 
            // note1Text
            // 
            this.note1Text.BackColor = System.Drawing.Color.Black;
            this.note1Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.note1Text.Enabled = false;
            this.note1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note1Text.ForeColor = System.Drawing.Color.White;
            this.note1Text.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.note1Text.Location = new System.Drawing.Point(88, 169);
            this.note1Text.Multiline = true;
            this.note1Text.Name = "note1Text";
            this.note1Text.ReadOnly = true;
            this.note1Text.Size = new System.Drawing.Size(473, 206);
            this.note1Text.TabIndex = 48;
            this.note1Text.Text = resources.GetString("note1Text.Text");
            // 
            // dlExeLabel
            // 
            this.dlExeLabel.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.dlExeLabel.AutoSize = true;
            this.dlExeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlExeLabel.LinkColor = System.Drawing.Color.DodgerBlue;
            this.dlExeLabel.Location = new System.Drawing.Point(323, 329);
            this.dlExeLabel.Name = "dlExeLabel";
            this.dlExeLabel.Size = new System.Drawing.Size(46, 20);
            this.dlExeLabel.TabIndex = 49;
            this.dlExeLabel.TabStop = true;
            this.dlExeLabel.Text = ".EXE";
            this.dlExeLabel.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.dlExeLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dlExeLabel_LinkClicked);
            // 
            // dlZipLabel
            // 
            this.dlZipLabel.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.dlZipLabel.AutoSize = true;
            this.dlZipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlZipLabel.LinkColor = System.Drawing.Color.DodgerBlue;
            this.dlZipLabel.Location = new System.Drawing.Point(279, 329);
            this.dlZipLabel.Name = "dlZipLabel";
            this.dlZipLabel.Size = new System.Drawing.Size(38, 20);
            this.dlZipLabel.TabIndex = 50;
            this.dlZipLabel.TabStop = true;
            this.dlZipLabel.Text = ".ZIP";
            this.dlZipLabel.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.dlZipLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dlZipLabel_LinkClicked);
            // 
            // dlScreenCapRecLabel
            // 
            this.dlScreenCapRecLabel.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.dlScreenCapRecLabel.AutoSize = true;
            this.dlScreenCapRecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlScreenCapRecLabel.LinkColor = System.Drawing.Color.DodgerBlue;
            this.dlScreenCapRecLabel.Location = new System.Drawing.Point(291, 209);
            this.dlScreenCapRecLabel.Name = "dlScreenCapRecLabel";
            this.dlScreenCapRecLabel.Size = new System.Drawing.Size(180, 20);
            this.dlScreenCapRecLabel.TabIndex = 51;
            this.dlScreenCapRecLabel.TabStop = true;
            this.dlScreenCapRecLabel.Text = "screen-capture-recorder";
            this.dlScreenCapRecLabel.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.dlScreenCapRecLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dlScreenCapRecLabel_LinkClicked);
            // 
            // documentationLabel
            // 
            this.documentationLabel.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.documentationLabel.AutoSize = true;
            this.documentationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentationLabel.LinkColor = System.Drawing.Color.DodgerBlue;
            this.documentationLabel.Location = new System.Drawing.Point(127, 417);
            this.documentationLabel.Name = "documentationLabel";
            this.documentationLabel.Size = new System.Drawing.Size(118, 20);
            this.documentationLabel.TabIndex = 52;
            this.documentationLabel.TabStop = true;
            this.documentationLabel.Text = "Documentation";
            this.documentationLabel.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.documentationLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.documentationLabel_LinkClicked);
            // 
            // bugReportLabel
            // 
            this.bugReportLabel.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.bugReportLabel.AutoSize = true;
            this.bugReportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugReportLabel.LinkColor = System.Drawing.Color.DodgerBlue;
            this.bugReportLabel.Location = new System.Drawing.Point(251, 417);
            this.bugReportLabel.Name = "bugReportLabel";
            this.bugReportLabel.Size = new System.Drawing.Size(84, 20);
            this.bugReportLabel.TabIndex = 53;
            this.bugReportLabel.TabStop = true;
            this.bugReportLabel.Text = "Bug report";
            this.bugReportLabel.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.bugReportLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.bugReportLabel_LinkClicked);
            // 
            // contactLabel
            // 
            this.contactLabel.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.LinkColor = System.Drawing.Color.DodgerBlue;
            this.contactLabel.Location = new System.Drawing.Point(341, 417);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(138, 20);
            this.contactLabel.TabIndex = 54;
            this.contactLabel.TabStop = true;
            this.contactLabel.Text = "Contact developer";
            this.contactLabel.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.contactLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.contactLabel_LinkClicked);
            // 
            // scaleBox
            // 
            this.scaleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scaleBox.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.scaleBox.Location = new System.Drawing.Point(283, 239);
            this.scaleBox.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.scaleBox.Name = "scaleBox";
            this.scaleBox.Size = new System.Drawing.Size(120, 23);
            this.scaleBox.TabIndex = 55;
            this.scaleBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scaleLabel.ForeColor = System.Drawing.Color.LightGray;
            this.scaleLabel.Location = new System.Drawing.Point(280, 217);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(120, 15);
            this.scaleLabel.TabIndex = 56;
            this.scaleLabel.Text = "Resolution scale (%)";
            // 
            // cachingMsBox
            // 
            this.cachingMsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cachingMsBox.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cachingMsBox.Location = new System.Drawing.Point(409, 239);
            this.cachingMsBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cachingMsBox.Name = "cachingMsBox";
            this.cachingMsBox.Size = new System.Drawing.Size(77, 23);
            this.cachingMsBox.TabIndex = 57;
            this.cachingMsBox.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // cachingMsLabel
            // 
            this.cachingMsLabel.AutoSize = true;
            this.cachingMsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cachingMsLabel.ForeColor = System.Drawing.Color.LightGray;
            this.cachingMsLabel.Location = new System.Drawing.Point(406, 217);
            this.cachingMsLabel.Name = "cachingMsLabel";
            this.cachingMsLabel.Size = new System.Drawing.Size(80, 15);
            this.cachingMsLabel.TabIndex = 58;
            this.cachingMsLabel.Text = "Caching (ms)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(274, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "v1.0.0.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Stream_Helper.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cachingMsLabel);
            this.Controls.Add(this.cachingMsBox);
            this.Controls.Add(this.scaleLabel);
            this.Controls.Add(this.scaleBox);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.bugReportLabel);
            this.Controls.Add(this.documentationLabel);
            this.Controls.Add(this.dlScreenCapRecLabel);
            this.Controls.Add(this.dlZipLabel);
            this.Controls.Add(this.dlExeLabel);
            this.Controls.Add(this.note1Text);
            this.Controls.Add(this.note1Label);
            this.Controls.Add(this.picture43);
            this.Controls.Add(this.picture169);
            this.Controls.Add(this.aspect169Radio);
            this.Controls.Add(this.aspect43Radio);
            this.Controls.Add(this.aspectSelectLabel);
            this.Controls.Add(this.selectSourceLabel);
            this.Controls.Add(this.btnSourceDesktop);
            this.Controls.Add(this.vFramerateLabel);
            this.Controls.Add(this.vFramerateBox);
            this.Controls.Add(this.btnSourceFile);
            this.Controls.Add(this.step3Label);
            this.Controls.Add(this.step2Label);
            this.Controls.Add(this.step1Label);
            this.Controls.Add(this.vlcNotFoundLabel);
            this.Controls.Add(this.streamURLbox);
            this.Controls.Add(this.vVertResLabel);
            this.Controls.Add(this.vHorizResLabel);
            this.Controls.Add(this.vVertRes);
            this.Controls.Add(this.vHorizRes);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.streamUrlLabel);
            this.Controls.Add(this.aSampleRateCombo);
            this.Controls.Add(this.aSampleLabel);
            this.Controls.Add(this.aBitrateBox);
            this.Controls.Add(this.aBitrateLabel);
            this.Controls.Add(this.vBitrateLabel);
            this.Controls.Add(this.vBitrateBox);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.selectFileLabel);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.ipCombo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStream);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.filePathBox);
            this.Controls.Add(this.appTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Stream Helper";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBitrateBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBitrateBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFramerateBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture169)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachingMsBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label appTitleLabel;
        private System.Windows.Forms.TextBox filePathBox;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnStream;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.ComboBox ipCombo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Label selectFileLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.NumericUpDown portBox;
        private System.Windows.Forms.NumericUpDown vBitrateBox;
        private System.Windows.Forms.Label vBitrateLabel;
        private System.Windows.Forms.Label aBitrateLabel;
        private System.Windows.Forms.NumericUpDown aBitrateBox;
        private System.Windows.Forms.Label aSampleLabel;
        private System.Windows.Forms.ComboBox aSampleRateCombo;
        private System.Windows.Forms.Label streamUrlLabel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox vHorizRes;
        private System.Windows.Forms.TextBox vVertRes;
        private System.Windows.Forms.Label vHorizResLabel;
        private System.Windows.Forms.Label vVertResLabel;
        private System.Windows.Forms.TextBox streamURLbox;
        private System.Windows.Forms.Label vlcNotFoundLabel;
        private System.Windows.Forms.Label step1Label;
        private System.Windows.Forms.Label step2Label;
        private System.Windows.Forms.Label step3Label;
        private System.Windows.Forms.Button btnSourceFile;
        private System.Windows.Forms.NumericUpDown vFramerateBox;
        private System.Windows.Forms.Label vFramerateLabel;
        private System.Windows.Forms.Button btnSourceDesktop;
        private System.Windows.Forms.Label selectSourceLabel;
        private System.Windows.Forms.Label aspectSelectLabel;
        private System.Windows.Forms.RadioButton aspect43Radio;
        private System.Windows.Forms.RadioButton aspect169Radio;
        private System.Windows.Forms.PictureBox picture169;
        private System.Windows.Forms.PictureBox picture43;
        private System.Windows.Forms.Label note1Label;
        private System.Windows.Forms.TextBox note1Text;
        private System.Windows.Forms.LinkLabel dlExeLabel;
        private System.Windows.Forms.LinkLabel dlZipLabel;
        private System.Windows.Forms.LinkLabel dlScreenCapRecLabel;
        private System.Windows.Forms.LinkLabel documentationLabel;
        private System.Windows.Forms.LinkLabel bugReportLabel;
        private System.Windows.Forms.LinkLabel contactLabel;
        private System.Windows.Forms.NumericUpDown scaleBox;
        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.NumericUpDown cachingMsBox;
        private System.Windows.Forms.Label cachingMsLabel;
        private System.Windows.Forms.Label label1;
    }
}

