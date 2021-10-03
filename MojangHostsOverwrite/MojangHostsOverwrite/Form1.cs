using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojangHostsOverwrite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AuthIP Auth1, Auth2, Auth3, Auth4, Auth5, Auth6, Auth7, Auth8, Auth9, Auth10, Auth11, Auth12, Auth13, Auth14, Auth15, Auth16, Auth17;
            SessionIP Session1, Session2, Session3, Session4, Session5, Session6, Session7, Session8, Session9, Session10, Session11, Session12, Session13, Session14;
            Auth1.__RoundtripTime__ = 1025;
            Auth2.__RoundtripTime__ = 1025;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
        }

        public void Ping(string IP)
        {
            Ping __ping__ = new Ping();
            PingOptions options = new PingOptions();
            options.DontFragment = true;
            byte[] buffer = Encoding.ASCII.GetBytes("test");
            int timeout = 1024;
            PingReply reply = __ping__.Send(IP, timeout, buffer, options);
        }

        struct AuthIP
        {
            public string __IP__;
            public int __RoundtripTime__;
        }

        struct SessionIP
        {
            public string __IP__;
            public int __RoundtripTime__;
        }
    }
}
