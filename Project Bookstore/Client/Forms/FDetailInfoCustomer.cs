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
        internal IpConnection ipConnection = new IpConnection();
        public FDetailInfoCustomer(int id)
        {
            idCustomer = id;
            InitializeComponent();
        }

        private void FDetailInfoCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                InfoDetailCustomer info = new InfoDetailCustomer();
                StringBuilder builder = ipConnection.ConnectToServer("request|infodetailcustomer " + idCustomer.ToString());
                info = JsonConvert.DeserializeObject<InfoDetailCustomer>(builder.ToString());
                lbCustomerName.Text = info.username;
                lbEmail.Text = info.email;
                lbMoney.Text = info.money.ToString();
                lbSpend.Text = info.spend.ToString();
                lbRecharge.Text = info.recharge.ToString();
                lbGetPoints.Text = info.getpoints.ToString();
                lbDateCreate.Text = info.createtime.ToString();
                foreach(ListPurchaseHistory item in info.listPurchaseHistories)
                {
                    dgvHistoryBuyBook.Rows.Add(item.bookname, item.price, item.dateBuy, item.pointPlus);
                }
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
