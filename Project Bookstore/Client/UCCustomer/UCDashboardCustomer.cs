using Client.Class;
using Client.Forms;
using Newtonsoft.Json;
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
                InfoDashboardCustomer info = new InfoDashboardCustomer();
                string data;
                string[] dataSplit;
                string message = "request|dashboardcustomer " + username;
                StringBuilder builder = ipConnection.ConnectToServer(message);
                info = JsonConvert.DeserializeObject<InfoDashboardCustomer>(builder.ToString());
                lbNumberOfBooksPurchase.Text = info.NumberofBooksPurchase.ToString();
                lbAmountPaid.Text = info.AmountPaid.ToString();
                lbDeposits.Text = info.Deposits.ToString();
                lbPoint.Text = info.Points.ToString();
                foreach(BookChart list in info.bookCharts)
                {
                    dgvBookChart.Rows.Add(list.top, list.bookname, list.numberofbooksold);
                }
                foreach(CustomerChart list in info.customerCharts)
                {
                    dgvCustomerChart.Rows.Add(list.top, list.username, list.numberofbookpurchase);
                }
            }
            catch
            {
                this.Invoke(new Action(() => MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)));

            }
        }
    }

}
