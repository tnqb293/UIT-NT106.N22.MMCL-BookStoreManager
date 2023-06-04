using Server.Class;
using Server.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        internal static ServerObject server;
        static Thread listenThread;
        StreamWriter logWriter;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                server = new ServerObject();
                listenThread = new Thread(new ThreadStart(server.Listen));
                listenThread.IsBackground = true;
                listenThread.Start();

            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex}");
                server.Disconnect();
            }
        }


        private void btnsSetting_Click(object sender, EventArgs e)
        {
            FSetting fsettings = new FSetting();
            fsettings.Show();
        }
    }
}
