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
        private void lbPrice_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UCListCustomerAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                List<InfoCustomer> infolist = new List<InfoCustomer>();
                string message = "request|listinfocustomer";
                StringBuilder builder = ipConnection.ConnectToServer(message);
                infolist = JsonConvert.DeserializeObject<List<InfoCustomer>>(builder.ToString());
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
            flowLayoutPanel1.Controls.Add(w);
        }
    }
}
