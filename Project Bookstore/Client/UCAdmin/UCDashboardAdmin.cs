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
        // Lấy dữ liệu username từ form FMainAdmin rồi gán giá trị đó vào biế userName
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
                string message = "request|dashboardadmin " + userName;
                //Gửi yêu cầu tới server bằng hàm ConnectToServer và lưu lại phản hồi từ server
                // vào biến builder
                StringBuilder builder = ipConnection.ConnectToServer(message);
                // Giải nén phản hồi của server với kiểu InfoDashboardAdmin
                info = JsonConvert.DeserializeObject<InfoDashboardAdmin>(builder.ToString());
                // Gán các giá trị tương ứng với label
                lbBookSold.Text = info.Booksold.ToString();
                lbRevenue.Text = info.Revenue.ToString();
                lbNumberofBookAvailable.Text = info.NumberOfBookCustomer.ToString();
                lbCustomerNumber.Text = info.CustomerNumber.ToString();
                // Hiển thị danh sách bảng xếp hạng sách được mua nhiều nhất
                foreach(BookChartAdmin list in info.bookCharts)
                {
                    dgvBookChart.Rows.Add(list.top, list.bookname, list.numberofbooksold);
                }
                // Hiển thị danh sách bảng xếp hạng khách hàng chi nhiều nhất
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
