﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.IO;
using System.Diagnostics;

namespace Stream_Helper
{
    public partial class Form1 : Form
    {
        public string filePath;
        public string streamPort;
        public string streamIP;
        public string streamAbitrate;
        public string streamVbitrate;
        public string streamVframerate;
        public string streamVvertResolution;
        public string streamVhorizResolution;
        public string streamAsampleRate;
        public string streamCommandLine;
        public string finalFilePath;
        public string vlcExePath;
        public bool vlcPathFound;
        public string streamSource;
        public string streamAspect;
        public string vScale;
        public string cachingMs;
        bool useCurrentDir;

        public Form1()
        {
            InitializeComponent();

            this.AutoScaleMode = AutoScaleMode.Dpi;

            // hide things until we know what the source will be
            aspectSelectLabel.Visible = false;
            aspect169Radio.Visible = false;
            aspect43Radio.Visible = false;
            selectFileLabel.Visible = false;
            step1Label.Visible = false;
            filePathBox.Visible = false;
            btnOpenFile.Visible = false;
            ipLabel.Visible = false;
            portLabel.Visible = false;
            step2Label.Visible = false;
            ipCombo.Visible = false;
            portBox.Visible = false;
            vBitrateLabel.Visible = false;
            vFramerateLabel.Visible = false;
            aBitrateLabel.Visible = false;
            aSampleLabel.Visible = false;
            vBitrateBox.Visible = false;
            vFramerateBox.Visible = false;
            aBitrateBox.Visible = false;
            aSampleRateCombo.Visible = false;
            step3Label.Visible = false;
            btnStream.Visible = false;
            btnReset.Visible = false;
            picture169.Visible = false;
            picture43.Visible = false;
            scaleLabel.Visible = false;
            scaleBox.Visible = false;
            cachingMsBox.Visible = false;
            cachingMsLabel.Visible = false;

            // hide the stream url until stream is started
            streamURLbox.Visible = false;
            streamUrlLabel.Visible = false;

            vHorizResLabel.Visible = false;
            vVertResLabel.Visible = false;
            vHorizRes.Visible = false;
            vVertRes.Visible = false;
            vHorizResLabel.Enabled = false;
            vVertResLabel.Enabled = false;
            vHorizRes.Enabled = false;
            vVertRes.Enabled = false;

            // get ip
            string strHostName = "";
            strHostName = System.Net.Dns.GetHostName();
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;

            // populate the ipaddresses combobox
            ips = GetAllIPv4Addresses();
            foreach (var ip in ips)
            {
                ipCombo.Items.Add(ip.Item2 + " - " + ip.Item1);
            }
            ipCombo.SelectedIndex = ipCombo.Items.Count - 1;

            string currentDir = System.AppDomain.CurrentDomain.BaseDirectory;
            
            // find vlc.exe
            if (File.Exists(@"vlc.exe"))
            {
                vlcExePath = currentDir;
                vlcNotFoundLabel.Visible = false;
                vlcPathFound = true;
                useCurrentDir = true;
            }

            if (vlcPathFound != true)
            {
                if (File.Exists(@"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe"))
                {
                    vlcExePath = (@"C:\Program Files (x86)\VideoLAN\VLC\");
                    vlcNotFoundLabel.Visible = false;
                    vlcPathFound = true;
                    useCurrentDir = false;
                }
            }

            if (vlcPathFound != true)
            {
                if (File.Exists(@"C:\Program Files\VideoLAN\VLC\vlc.exe"))
                {
                    vlcExePath = (@"C:\Program Files\VideoLAN\VLC\");
                    vlcNotFoundLabel.Visible = false;
                    useCurrentDir = false;
                }
            }

            if (vlcExePath == null)
            {
                MessageBox.Show("Cannot find VLC Media Player.\n\nTo use Stream helper, you must either install VLC Media Player in the\ndefault location, or place Stream Helper in the same folder with vlc.exe");
                vlcNotFoundLabel.Visible = true;
                return;
            }
        }
        
        // get the ip addresses
        private List<Tuple<string, string>> ips;
        private List<Tuple<string, string>> GetAllIPv4Addresses()
        {
            List<Tuple<string, string>> ipList = new List<Tuple<string, string>>();
            foreach (var ni in NetworkInterface.GetAllNetworkInterfaces())
            {

                foreach (var ua in ni.GetIPProperties().UnicastAddresses)
                {
                    if (ua.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        ipList.Add(Tuple.Create(ni.Name, ua.Address.ToString()));
                    }
                }
            }
            return ipList;
        }

        // make window movable
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        //

        // close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            // show the openfiledialog to select a video file  
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Video Files|*.avi;*.mp4;*.mkv;*.mpg;*.flv;*.ogg;*.webm;*.wmv;*.3g2;*.3gp;*.3gp2;*.3gpp;*.amv;*.asf;*.bik;*.bin;*.divx;*.drc;*.dv;*.f4v;*.gvi;*.gxf;*.iso;*,m1v;*.m2v;*.m2t;*.m2ts;*.m4v;*.mkv;*.mov;*.mp2;*.mp2v;*.mp4v;*.mpe;*.mpeg;*.mpeg1;*.mpeg2;*.mpeg4;*.mpv2;*.mts;*.mtv;*.mxf;*.mxg;*.nsv;*.nuv;*.ogm;*.ogv;*.ogx;*.ps;*.rec;*.rm;*.rmbv;*.rpl;*.thp;*.tod;*.ts;*.tts;*.txd;*.vob;*.vro;*.wm;*.wtv;*.xesc|All files (*.*)|*.*";
            openFileDialog1.Title = "Select a Video File";

            // If the user clicked OK in the dialog and a video file was selected, open it.  
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePathBox.Text = openFileDialog1.FileName;
                filePath = filePathBox.Text;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
        }

        // start stream button
        private void btnStream_Click(object sender, EventArgs e)
        {

            var selectedIP = ips.ElementAt(ipCombo.SelectedIndex).Item2;

            if (streamSource == "file")
            {
                if (filePath == null)
                {
                    MessageBox.Show("Please select a video file");
                    return;
                }
            }

            if (selectedIP.ToString() == "127.0.0.1")
            {
                MessageBox.Show("Your ip address is set to an internal ip address (127.0.0.1),\nwhich is not reachable by other devices.\n\nPlease select the ip address of your primary network adapter.");
                return;
            }

            streamPort = portBox.Value.ToString();
            streamAbitrate = aBitrateBox.Value.ToString();
            streamAsampleRate = aSampleRateCombo.Text;
            streamVbitrate = vBitrateBox.Value.ToString();
            streamVframerate = vFramerateBox.Value.ToString();
            streamVhorizResolution = vHorizRes.Text;
            streamVvertResolution = vVertRes.Text;
            cachingMs = cachingMsBox.Value.ToString();

            if (scaleBox.Value == 100)
            {
                vScale = "1.0";
            }
            else
            {
                vScale = ("0." + scaleBox.Value.ToString());
            }

            if (streamSource == "file")
            {
                finalFilePath = ("file:///" + (filePath.Replace(@"\", @"/").Replace(@" ", @"%20")));

                try
                {
                    // old command for wp
                    //streamCommandLine = (finalFilePath + " --sout=#transcode{vcodec=h264,vb=" + streamVbitrate + ",fps=" + streamVframerate + ",acodec=mpga,ab=" + streamAbitrate + ",channels=2,samplerate=" + streamAsampleRate + "}:std{access=http,mux=ts,dst=:" + streamPort + "} --no-sout-rtp-sap --no-sout-standard-sap --ttl=5 --sout-transcode-scale=" + vScale + " --sout-keep  :file-caching=" + cachingMs + "");

                    // new command
                    streamCommandLine = (finalFilePath + " --sout=#transcode{vcodec=h264,vb=" + streamVbitrate + ",fps=" + streamVframerate + ",acodec=mp3,ab=" + streamAbitrate + ",channels=2,samplerate=" + streamAsampleRate + "}:std{access=http,mux=ffmpeg{mux=flv},dst=:" + streamPort + "} --no-sout-rtp-sap --no-sout-standard-sap --ttl=5 --sout-transcode-scale=" + vScale + " --sout-keep  :file-caching=" + cachingMs + "");
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }

            if (streamSource == "desktop")
            {
                if (aspect169Radio.Checked == true)
                {
                    streamAspect = @"16\:9";
                }
                if (aspect43Radio.Checked == true)
                {
                    streamAspect = @"4\:3";
                }

                try
                {
                    streamCommandLine = ("dshow:// --sout=#transcode{vcodec=h264,vb=" + streamVbitrate + ",fps=" + streamVframerate + ",acodec=mp3,ab=" + streamAbitrate + ",channels=2,samplerate=" + streamAsampleRate + "}:std{access=http,mux=ffmpeg{mux=flv},dst=:" + streamPort + "} --no-sout-rtp-sap --no-sout-standard-sap --ttl=5 --sout-transcode-scale=" + vScale + " --sout-keep :dshow-vdev=screen-capture-recorder :dshow-adev=virtual-audio-capturer :dshow-aspect-ratio=" + streamAspect + " :dshow-caching=" + cachingMs + "");
                }
                catch
                {
                    MessageBox.Show("Error");
                    return;
                }

            }

            // populate the stream url and make it visible
            streamURLbox.Text = ("http://" + selectedIP + ":" + portBox.Text);
            streamURLbox.Visible = true;
            streamUrlLabel.Visible = true;

            // start the stream with vlc
            Process process = new Process();
            if (useCurrentDir == true)
            {
                process.StartInfo.UseShellExecute = false;
            }
            else
            {
                process.StartInfo.UseShellExecute = true;
            }
            process.StartInfo.FileName = "vlc.exe";
            process.StartInfo.WorkingDirectory = vlcExePath;
            process.StartInfo.Arguments = streamCommandLine;
            process.Start();
        }

        // reset form button
        private void btnReset_Click(object sender, EventArgs e)
        {
            streamSource = "";
            filePathBox.Text = null;
            portBox.Value = decimal.Parse("8080");
            vBitrateBox.Value = decimal.Parse("3000");
            vFramerateBox.Value = decimal.Parse("30");
            aBitrateBox.Value = decimal.Parse("128");
            aSampleRateCombo.SelectedItem = "44100";
            filePath = null;
            finalFilePath = null;
            streamURLbox.Text = null;
            streamURLbox.Visible = false;
            streamUrlLabel.Visible = false;
            streamCommandLine = null;

            selectSourceLabel.Visible = true;
            btnSourceFile.Visible = true;
            btnSourceDesktop.Visible = true;

            aspectSelectLabel.Visible = false;
            aspect43Radio.Visible = false;
            aspect169Radio.Visible = false;
            aspect169Radio.Checked = true;
            aspect43Radio.Checked = false;
            picture43.Visible = false;
            picture169.Visible = false;
            selectFileLabel.Visible = false;
            step1Label.Visible = false;
            filePathBox.Visible = false;
            btnOpenFile.Visible = false;
            ipLabel.Visible = false;
            portLabel.Visible = false;
            step2Label.Visible = false;
            ipCombo.Visible = false;
            portBox.Visible = false;
            vBitrateLabel.Visible = false;
            vFramerateLabel.Visible = false;
            aBitrateLabel.Visible = false;
            aSampleLabel.Visible = false;
            vBitrateBox.Visible = false;
            vFramerateBox.Visible = false;
            aBitrateBox.Visible = false;
            aSampleRateCombo.Visible = false;
            step3Label.Visible = false;
            btnStream.Visible = false;
            btnReset.Visible = false;

            note1Text.Visible = true;
            btnLatestVLC.Visible = true;
            dlScreenCapRecLabel.Visible = true;
            documentationLabel.Visible = true;
            githubLabel.Visible = true;
            scaleLabel.Visible = false;
            scaleBox.Visible = false;
            scaleBox.Value = 100;
            cachingMsBox.Value = 2000;
            cachingMsBox.Visible = false;
            cachingMsLabel.Visible = false;
        }

        // stream a file button
        private void btnSourceFile_Click(object sender, EventArgs e)
        {
            streamSource = "file";

            note1Text.Visible = false;
            btnLatestVLC.Visible = false;
            dlScreenCapRecLabel.Visible = false;
            documentationLabel.Visible = false;
            githubLabel.Visible = false;

            selectSourceLabel.Visible = false;
            btnSourceFile.Visible = false;
            btnSourceDesktop.Visible = false;
            selectFileLabel.Visible = true;
            step1Label.Visible = true;
            filePathBox.Visible = true;
            btnOpenFile.Visible = true;
            ipLabel.Visible = true;
            portLabel.Visible = true;
            step2Label.Visible = true;
            ipCombo.Visible = true;
            portBox.Visible = true;
            vBitrateLabel.Visible = true;
            vFramerateLabel.Visible = true;
            aBitrateLabel.Visible = true;
            aSampleLabel.Visible = true;
            vBitrateBox.Visible = true;
            vFramerateBox.Visible = true;
            aBitrateBox.Visible = true;
            aSampleRateCombo.Visible = true;
            step3Label.Visible = true;
            btnStream.Visible = true;
            btnReset.Visible = true;
            scaleLabel.Visible = true;
            scaleBox.Visible = true;
            cachingMsBox.Visible = true;
            cachingMsLabel.Visible = true;
        }
        // stream desktop button
        private void btnSourceDesktop_Click(object sender, EventArgs e)
        {
            streamSource = "desktop";

            note1Text.Visible = false;
            btnLatestVLC.Visible = false;
            dlScreenCapRecLabel.Visible = false;
            documentationLabel.Visible = false;
            githubLabel.Visible = false;

            selectSourceLabel.Visible = false;
            btnSourceFile.Visible = false;
            btnSourceDesktop.Visible = false;

            step1Label.Visible = true;
            aspectSelectLabel.Visible = true;
            aspect43Radio.Visible = true;
            aspect169Radio.Visible = true;
            picture169.Visible = true;
            picture43.Visible = true;
            ipLabel.Visible = true;
            portLabel.Visible = true;
            step2Label.Visible = true;
            ipCombo.Visible = true;
            portBox.Visible = true;
            vBitrateLabel.Visible = true;
            vFramerateLabel.Visible = true;
            aBitrateLabel.Visible = true;
            aSampleLabel.Visible = true;
            vBitrateBox.Visible = true;
            vFramerateBox.Visible = true;
            aBitrateBox.Visible = true;
            aSampleRateCombo.Visible = true;
            step3Label.Visible = true;
            btnStream.Visible = true;
            btnReset.Visible = true;
            scaleLabel.Visible = true;
            scaleBox.Visible = true;
            cachingMsBox.Visible = true;
            cachingMsLabel.Visible = true;
        }

        // dl screen-capture-recorder button
        private void dlScreenCapRecLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/14ejrsFYBZ6GrFRagYjRhYaeDI1TiR5pW/view?usp=sharing");

        }

        // documentation link button
        private void documentationLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/19L79dHrFhd6zBT22FQNhkZa6Eae0NJWZC0n_zIwKUjw/edit?usp=sharing");

        }

        // github button
        private void githubLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/blevok/Stream-Helper");

        }

        // latest vlc button
        private void btnLatestVLC_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.videolan.org/vlc/index.html");
        }
    }
}
