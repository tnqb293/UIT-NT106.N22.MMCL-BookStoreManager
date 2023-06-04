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
    public partial class UCListBookCustomer : UserControl
    {
        public UCListBookCustomer(string user)
        {
            InitializeComponent();
            infoUser.username = user;
        }
        InfoUser infoUser = new InfoUser();
        internal IpConnection ipConnection = new IpConnection();
        internal Thread receiveThread { get; set; }
        public static bool checkBuy;
        private void UCListBookCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                List<InfoBookList> infobookList = new List<InfoBookList>();
                string message = "itembook " +  infoUser.username;
                StringBuilder builder = ipConnection.ConnectToServer(message);
                infobookList = JsonConvert.DeserializeObject<List<InfoBookList>>(builder.ToString());
                foreach(InfoBookList book in infobookList)
                {
                    AddItem(book.bookname, book.writername, book.country, book.language, book.price, book.numberofbookssold, byteToImage(book.coverImage));
                }
            }
            catch
            {
                this.Invoke(new Action(() => MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)));
            }
        }
        private void AddItem(string bookname, string writername, string country, string language, int price, int numberofbooksold, Image coverimage)
        {
            var w = new UCItemListBookCustomer(infoUser.username)
            {
                bookName = bookname,
                writerName = writername,
                language = language,
                country = country,
                price = price,
                numberofbookssold = numberofbooksold,
                coverImage = coverimage
            };
            flowLayoutPanel1.Controls.Add(w);
        }
        public Image byteToImage(byte[] bytesPicture)
        {
            using (MemoryStream ms = new MemoryStream(bytesPicture))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }
    }
}
