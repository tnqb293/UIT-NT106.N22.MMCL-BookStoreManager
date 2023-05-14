using Client.Class;
using Client.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Client.Forms
{
    public partial class FMainCustomer : Form
    {
        private IpConnection ipConnection = new IpConnection();
        public Thread receiveThread { get; set; }
        InfoUser info = new InfoUser();
        public FMainCustomer(string user)
        {
            InitializeComponent();
            info.username = user;

        }
        private void pnContentAdmin_Paint(object sender, PaintEventArgs e)
        {
            UCDashboardCustomer uCDashboardCustomer = new UCDashboardCustomer(info.username);
            addUserControl(uCDashboardCustomer);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnContentCustomer.Controls.Clear();
            pnContentCustomer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void FMainCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                string data;
                string[] dataSplit;
                string message = info.username + " dashboardcustomer";
                StringBuilder builder = ipConnection.messageFromServer(message);
                data = builder.ToString();
                dataSplit = data.Split(' ');
                lbNameCustomer.Text = info.username;
                lbMoney.Text = dataSplit[0];
                receiveThread = new Thread(new ThreadStart(ipConnection.receiveMessage));
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
            catch
            {
                this.Invoke(new Action(() => MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)));

            }
        }
        private void pnControlCustomer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
