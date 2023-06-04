using Client.Class;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UC
{
    public partial class UCDashboardAdmin : UserControl
    {
        public UCDashboardAdmin(string username)
        {
            InitializeComponent();
            userName = username;
        }
        private static string userName;
        IpConnection ipConnection = new IpConnection();
        private void UCDashboardAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                InfoDashboardAdmin info = new InfoDashboardAdmin();
                string data;
                string[] dataSplit;
                string message = "request|dashboardadmin " + userName;
                StringBuilder builder = ipConnection.ConnectToServer(message);
                info = JsonConvert.DeserializeObject<InfoDashboardAdmin>(builder.ToString());
                lbBookSold.Text = info.Booksold.ToString();
                lbRevenue.Text = info.Revenue.ToString();
                lbNumberofBookAvailable.Text = info.NumberOfBookCustomer.ToString();
                lbCustomerNumber.Text = info.CustomerNumber.ToString();
                foreach(BookChartAdmin list in info.bookCharts)
                {
                    dgvBookChart.Rows.Add(list.top, list.bookname, list.numberofbooksold);
                }
                foreach(CustomerChartAdmin list in info.customerCharts)
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
