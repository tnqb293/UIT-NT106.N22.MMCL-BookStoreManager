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

namespace Client.UCAdmin
{
    public partial class UCListCustomerAdmin : UserControl
    {
        public UCListCustomerAdmin()
        {
            InitializeComponent();
        }
        internal IpConnection ipConnection = new IpConnection();

        private void UCListCustomerAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo danh sách với kiểu InfoCustomer và biến infolist
                List<InfoCustomer> infolist = new List<InfoCustomer>();
                string message = "request|listinfocustomer";
                //Gửi yêu cầu tới server bằng hàm ConnectToServer và lưu lại phản hồi từ server
                // vào biến builder
                StringBuilder builder = ipConnection.ConnectToServer(message);
                // Giải nén biến buidler ra vào danh sách với kiểu InfoCustomer
                infolist = JsonConvert.DeserializeObject<List<InfoCustomer>>(builder.ToString());
                // Hiển thị danh sách thông tin người dùng
                foreach(InfoCustomer item in infolist)
                {
                    AddItem(item.idCustomer, item.nameCustomer, item.money, item.getPoints, item.datetime);
                }
            }
            catch
            {

            }
        }
        private void AddItem(int idcustomer, string namecustomer, int money, int getpoint, DateTime datetime)
        {
            var w = new UCItemCustomerAdmin()
            {
                idCustomer = idcustomer,
                nameCustomer = namecustomer,
                money = money,
                getPoints = getpoint,
                datetime = datetime
            };
            // Sau khi gán các giá trị trên xong thì sẽ thêm 1 item vào flowLayoutPanel
            flowLayoutPanel1.Controls.Add(w);
        }
    }
}
