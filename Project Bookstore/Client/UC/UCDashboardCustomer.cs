using Client.Class;
using Client.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static Client.FLoginRegister;

namespace Client.UC
{
    public partial class UCDashboardCustomer : UserControl
    {
        public UCDashboardCustomer(string user)
        {
            InitializeComponent();
            username = user;
        }
        IpConnection ipConnection = new IpConnection();
        private Thread receiveThread { get; set; }
        public string username { get; set; }
        private void btnExitDashboardCustomer_Click(object sender, EventArgs e)
        {
            //Disconnect();
        }
        private void pnAmountPaid_Paint(object sender, PaintEventArgs e)
        {

        }
        private void UCDashboardCustomer_Load(object sender, EventArgs e)
        {

            try
            {
                string data;
                string[] dataSplit;
                string message = username + " dashboardcustomer";
                StringBuilder builder = ipConnection.messageFromServer(message);
                data = builder.ToString();
                dataSplit = data.Split(' ');
                lbNumberOfBooksPurchase.Text = dataSplit[2];
                lbAmountPaid.Text = dataSplit[1];
                receiveThread = new Thread(new ThreadStart(ipConnection.receiveMessage));
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
            catch
            {
                this.Invoke(new Action(() => MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)));

            }
        }
    }

}
