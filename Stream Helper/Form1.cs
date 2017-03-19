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
using System.Text.RegularExpressions;

namespace Stream_Helper
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();




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

           
            

            //ip = addr[3].ToString();
            //ipaddress.Text = ("http://" + ip + "/");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

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

        // start stream button
        private void btnStream_Click(object sender, EventArgs e)
        {

            // populate the url label
            var selectedIP = ips.ElementAt(ipCombo.SelectedIndex).Item2;
            streamURL.Text = ("http://" + selectedIP + ":" + portBox.Text);
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
            //// Show the dialog that allows user to select a file, the 
            //// call will result a value from the DialogResult enum
            //// when the dialog is dismissed.
            //DialogResult result = this.openFileDialog.ShowDialog();
            //// if a file is selected
            //if (result == DialogResult.OK)
            //{
            //    // Set the selected file URL to the textbox
            //    this.fileURLTextBox.Text = this.openFileDialog.FileName;
            //}

            //new OpenFileDialog();

            // Displays an OpenFileDialog so the user can select a Cursor.  
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Video Files|*.mp4;*.avi;*.flv;*.mkv|All files (*.*)|*.*";
            openFileDialog1.Title = "Select a Video File";

            // Show the Dialog.  
            // If the user clicked OK in the dialog and  
            // a .CUR file was selected, open it.  
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //string pathText = Text.Replace(@"\", @"/");
                //Regex pattern = new Regex("[;,\t\r ]|[\n]{2}");
                filePathBox.Text = ("file:///" + openFileDialog1.FileName).Replace(@"\", @"/").Replace(@" ", @"%");
            }


        }



        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            DialogResult result = openFileDialog1.ShowDialog();
            // if a file is selected
            //if (result == DialogResult.OK)
            //{
            //    // Set the selected file URL to the textbox
            //    //filePathBox.Text = openFileDialog1.InitialDirectory + openFileDialog1.FileName.ToString();
            //}
        }
    }
}
