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
            this.label1 = new System.Windows.Forms.Label();
            this.filePathBox = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnStream = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.streamURL = new System.Windows.Forms.Label();
            this.ipCombo = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.NumericUpDown();
            this.vBitrateBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.aBitrateBox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.aSampleRateCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBitrateBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBitrateBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stream Helper";
            // 
            // filePathBox
            // 
            this.filePathBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathBox.Location = new System.Drawing.Point(19, 104);
            this.filePathBox.Name = "filePathBox";
            this.filePathBox.Size = new System.Drawing.Size(488, 23);
            this.filePathBox.TabIndex = 2;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Location = new System.Drawing.Point(513, 103);
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
            this.btnStream.Location = new System.Drawing.Point(407, 332);
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
            // streamURL
            // 
            this.streamURL.AutoSize = true;
            this.streamURL.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.streamURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streamURL.ForeColor = System.Drawing.Color.LightGray;
            this.streamURL.Location = new System.Drawing.Point(100, 523);
            this.streamURL.Name = "streamURL";
            this.streamURL.Size = new System.Drawing.Size(98, 20);
            this.streamURL.TabIndex = 6;
            this.streamURL.Text = "Stream URL";
            // 
            // ipCombo
            // 
            this.ipCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipCombo.FormattingEnabled = true;
            this.ipCombo.Location = new System.Drawing.Point(19, 173);
            this.ipCombo.Name = "ipCombo";
            this.ipCombo.Size = new System.Drawing.Size(373, 24);
            this.ipCombo.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(16, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select the ip address of your primary network adapter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(16, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select a video file to stream";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(404, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select a port";
            // 
            // portBox
            // 
            this.portBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portBox.Location = new System.Drawing.Point(407, 174);
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
            this.portBox.Size = new System.Drawing.Size(120, 23);
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
            this.vBitrateBox.Location = new System.Drawing.Point(19, 241);
            this.vBitrateBox.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.vBitrateBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.vBitrateBox.Name = "vBitrateBox";
            this.vBitrateBox.Size = new System.Drawing.Size(126, 23);
            this.vBitrateBox.TabIndex = 13;
            this.vBitrateBox.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(16, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Video Bitrate (kb/s)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(151, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Audio Bitrate (kb/s)";
            // 
            // aBitrateBox
            // 
            this.aBitrateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aBitrateBox.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.aBitrateBox.Location = new System.Drawing.Point(151, 241);
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
            this.aBitrateBox.Size = new System.Drawing.Size(129, 23);
            this.aBitrateBox.TabIndex = 16;
            this.aBitrateBox.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(283, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Audio Sample Rate (Hz)";
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
            this.aSampleRateCombo.Location = new System.Drawing.Point(286, 241);
            this.aSampleRateCombo.Name = "aSampleRateCombo";
            this.aSampleRateCombo.Size = new System.Drawing.Size(157, 24);
            this.aSampleRateCombo.TabIndex = 18;
            this.aSampleRateCombo.Text = "44100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(96, 496);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Open this URL in Stream Theater VR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.aSampleRateCombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.aBitrateBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vBitrateBox);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipCombo);
            this.Controls.Add(this.streamURL);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStream);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.filePathBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBitrateBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBitrateBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filePathBox;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnStream;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label streamURL;
        private System.Windows.Forms.ComboBox ipCombo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown portBox;
        private System.Windows.Forms.NumericUpDown vBitrateBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown aBitrateBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox aSampleRateCombo;
        private System.Windows.Forms.Label label8;
    }
}

