using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UC
{
    public partial class UCDashboardCustomer : UserControl
    {
        public UCDashboardCustomer()
        {
            InitializeComponent();
        }
        TcpClient client { get; set; }
        NetworkStream stream { get; set; }
        private void btnExitDashboardCustomer_Click(object sender, EventArgs e)
        {
            Disconnect();
        }
        private void Disconnect()
        {
            if (stream != null)
            {
                stream.Close();
            }
            if (client != null)
            {
                client.Close();
            }
        }
    }
}
