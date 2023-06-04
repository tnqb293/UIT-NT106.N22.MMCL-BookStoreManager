using Client.Class;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UC
{
    public partial class UCListPurchaseHistoryCustomer : UserControl
    {
        public UCListPurchaseHistoryCustomer(string user)
        {
            InitializeComponent();
            infoUser.username = user;
        }

        InfoUser infoUser = new InfoUser();
        internal IpConnection ipConnection = new IpConnection();
        private void UCPurchaseHistoryCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                List<InfoHistoryPurchased> infoList = new List<InfoHistoryPurchased>();
                string message = "request|historylist " + infoUser.username;
                StringBuilder builder = ipConnection.ConnectToServer(message);
                infoList = JsonConvert.DeserializeObject<List<InfoHistoryPurchased>>(builder.ToString());
                foreach(InfoHistoryPurchased item in infoList)
                {
                    AddItem(item.tradingcode, byteToImage(item.imagecover), item.bookname, item.price, item.datetime, item.getPoint);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        private void AddItem(int tradingcode, Image imagecover, string bookname, int price, DateTime datetime, int getPoint)
        {
            var w = new UCItemPurchaseHistoryCustomer(infoUser.username)
            {
                tradingcode = tradingcode,
                bookname = bookname,
                imagecover = imagecover,
                price = price,
                datetime = datetime,
                getpoints = getPoint
            };
            flowLayoutPanel1.Controls.Add(w);
        }
        public Image byteToImage(byte[] bytesPicture)
        {
            using(MemoryStream ms = new MemoryStream(bytesPicture))
            {
                Image image = Image.FromStream(ms);
                return image;
            }    
        }
    }
}
