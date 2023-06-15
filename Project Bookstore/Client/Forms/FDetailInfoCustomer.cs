using Client.Class;
using Newtonsoft.Json;
using Server.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FDetailInfoCustomer : Form
    {
        private static int idCustomer;
        // Khởi tạo biến ipConnection
        internal IpConnection ipConnection = new IpConnection();
        // Hàm FDetailInfoCustomer có nhiệm vụ lưu trữ thông tin id ở bên UCItemCustomerAdmin
        public FDetailInfoCustomer(int id)
        {
            idCustomer = id;
            InitializeComponent();
        }
        /// <summary>
        /// Hàm này sẽ gửi yêu cầu tới server và nhận thông tin về danh sách của người dùng mà server
        /// gửi về
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FDetailInfoCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo biến info với class InfoDetailCustomer để nhận thông tin mà server gửi về
                InfoDetailCustomer info = new InfoDetailCustomer();
                // Gửi yêu cầu tới server bằng biến ConnectToServer và lưu trữ dữ liệu mà server gửi về bằng biến builder
                StringBuilder builder = ipConnection.ConnectToServer("request|infodetailcustomer " + idCustomer.ToString());
                // Giải nén đối tượng ra kiểu info và lưu trữ chúng với mỗi lable tương ứng
                info = JsonConvert.DeserializeObject<InfoDetailCustomer>(builder.ToString());
                lbCustomerName.Text = info.username;
                lbEmail.Text = info.email;
                lbMoney.Text = info.money.ToString();
                lbSpend.Text = info.spend.ToString();
                lbRecharge.Text = info.recharge.ToString();
                lbGetPoints.Text = info.getpoints.ToString();
                lbDateCreate.Text = info.createtime.ToString();
                // Hiển thị danh sách về lịch sủ mua hàng của khách hàng lên datagridview
                foreach(ListPurchaseHistory item in info.listPurchaseHistories)
                {
                    dgvHistoryBuyBook.Rows.Add(item.bookname, item.price, item.dateBuy, item.pointPlus);
                }
                // Hiển thị danh sách về lịch sử nạp tiền của khách hàng lên datagridview
                foreach(ListRechargeHistory item in info.listRechargeHistories)
                {
                    dgvHistoryRecharge.Rows.Add(item.idtrade, item.denomination, item.timerecharge, item.categoryCard, item.serinumber, item.cardnumber);
                }
            }
            catch
            {
                this.Invoke(new Action(() => MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)));
            }
        }
    }
}
