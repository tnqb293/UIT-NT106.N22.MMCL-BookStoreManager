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
    public partial class UCListPurchaseBookCustomer : UserControl
    {
        public UCListPurchaseBookCustomer(string user)
        {
            InitializeComponent();
            infoUser.username = user;
        }
        InfoUser infoUser = new InfoUser();
        internal IpConnection ipConnection = new IpConnection();
        internal Thread receiveThread { get; set; }

        private void UCListPurchaseBookCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                List<InfoPurchasedBook> infobookList = new List<InfoPurchasedBook>();
                string message = "request|purchaselistbook " + infoUser.username;
                StringBuilder builder = ipConnection.ConnectToServer(message);
                infobookList = JsonConvert.DeserializeObject<List<InfoPurchasedBook>>(builder.ToString());
                foreach(InfoPurchasedBook book in infobookList)
                {
                    AddItem(book.bookname, book.writername, book.country, book.language, book.price, book.numberofbookssold, byteToImage(book.coverImage));
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        private void AddItem(string bookname, string writername, string country, string language, int price, int numberofbookssold, Image covereImage)
        {
            var w = new UCItemReadBookCustomer(infoUser.username)
            {
                bookName = bookname,
                writername = writername,
                country = country,
                language = language,
                price = price,
                numberofbookssold = numberofbookssold,
                coverImage = covereImage
            };
            flowLayoutPanel1.Controls.Add(w);
        }
        public Image byteToImage(byte[] bytesPicture)
        {
            using (MemoryStream ms = new MemoryStream(bytesPicture))
            {
                Image image =  Image.FromStream(ms);
                return image;
            }
        }
    }
}
