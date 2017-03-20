using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public string streamVvertResolution;
        public string streamVhorizResolution;
        public string streamAsampleRate;
        public string streamCommandLine;
        public string finalFilePath;
        public string vlcExePath;
        public Form1()
        {
            InitializeComponent();

            // hide the stream url until stream is started
            streamURLbox.Visible = false;
            label8.Visible = false;

            // get ip
            //string ip = "";
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

            // find vlc/exe
            // fixme: need to add windows 10 file paths
            // also need to test dropping this app in vlc folder while other paths are broken
            if (File.Exists(@"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe"))
            {
                vlcExePath = (@"C:\Program Files (x86)\VideoLAN\VLC\");
                label11.Visible = false;
            }
            if (File.Exists(@"C:\Program Files\VideoLAN\VLC\vlc.exe"))
            {
                vlcExePath = (@"C:\Program Files\VideoLAN\VLC\");
                label11.Visible = false;
            }
            if (File.Exists(@"vlc.exe"))
            {
                vlcExePath = "";
                label11.Visible = false;
            }
            if (vlcExePath == null)
            {
                MessageBox.Show("Cannot find VLC Media Player.\n\nTo use Stream helper, you must either install VLC Media Player in the\ndefault location, or place Stream Helper in the same folder with vlc.exe");
                label11.Visible = true;
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

            if (filePath == null)
            {
                MessageBox.Show("Please select a video file");
                return;
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
            streamVhorizResolution = vHorizRes.Text;
            streamVvertResolution = vVertRes.Text;
            finalFilePath = ("file:///" + (filePath.Replace(@"\", @"/").Replace(@" ", @"%20")));

            if (streamVhorizResolution == "Auto")
            {
                streamCommandLine = (finalFilePath + " --sout=#transcode{vcodec=h264,vb=" + streamVbitrate + ",fps=30,scale=Auto,acodec=mpga,ab=" + streamAbitrate + ",channels=2,samplerate=" + streamAsampleRate + "}:http{mux=ts,dst=:" + streamPort + "/} :sout-all :sout-keep");
            }
            else
            {
                streamCommandLine = (finalFilePath + " --sout=#transcode{vcodec=h264,vb=" + streamVbitrate + ",fps=30,scale=Auto,width=" + streamVhorizResolution +",height=" + streamVvertResolution + ",acodec=mpga,ab=" + streamAbitrate + ",channels=2,samplerate=" + streamAsampleRate + "}:http{mux=ts,dst=:" + streamPort + "/} :sout-all :sout-keep");
            }

            // populate the stream url and make it visible
            streamURLbox.Text = ("http://" + selectedIP + ":" + portBox.Text);
            streamURLbox.Visible = true;
            label8.Visible = true;

            // start the stream with vlc
            Process process = new Process();
            process.StartInfo.FileName = "vlc.exe";
            process.StartInfo.WorkingDirectory = vlcExePath;
            process.StartInfo.Arguments = streamCommandLine;
            process.Start();
        }

        // reset form button
        private void btnReset_Click(object sender, EventArgs e)
        {
            filePathBox.Text = null;
            portBox.Value = decimal.Parse("8080");
            vBitrateBox.Value = decimal.Parse("1000");
            vHorizRes.Text = "Auto";
            vVertRes.Text = "Auto";
            aBitrateBox.Value = decimal.Parse("128");
            aSampleRateCombo.SelectedItem = "44100";
            filePath = null;
            finalFilePath = null;
            streamURLbox.Text = null;
            streamURLbox.Visible = false;
            label8.Visible = false;
            streamCommandLine = null;
        }
    }
}
