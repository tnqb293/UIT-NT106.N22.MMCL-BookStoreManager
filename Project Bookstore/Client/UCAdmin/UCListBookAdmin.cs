using Client.Class;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Client.UC.UCListBookAdmin;

namespace Client.UC
{
    public partial class UCListBookAdmin : UserControl
    {
        //internal class Infobook
        //{
        //    internal string bookname { get; set; }
        //    internal string writername { get; set; }
        //    internal string category { get; set; }
        //    internal string country { get; set; }
        //    internal int price { get; set; }
        //    internal int numberOfBookRemaining { get; set; }
        //    internal string coverImage { get; set; }
        //}
        InfoUser infoUser = new InfoUser();
        internal IpConnection ipConnection = new IpConnection();
        internal Thread receiveThread { get; set; }
        public UCListBookAdmin(string user)
        {
            InitializeComponent();
            infoUser.username = user;
        }

        private void flpListBookAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UCListBookAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                List<InfoBookList> infobookList = new List<InfoBookList>();
                string message = "itembook " + infoUser.username;
                StringBuilder builder = ipConnection.ConnectToServer(message);
                string data = builder.ToString();
                infobookList = JsonConvert.DeserializeObject<List<InfoBookList>>(data);
                foreach (InfoBookList book in infobookList)
                {
                    AddItem(book.bookname, book.writername, book.country, book.language, book.price, book.numberofbookssold, byteToImage(book.coverImage));
                }
            }
            catch
            {
                this.Invoke(new Action(() => MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)));
            }
        }
        private void AddItem(string bookname, string writername, string country, string language, int price, int numberofbookssold, Image coverimage)
        {
            var w = new UCItemListBookAdmin()
            {
                bookName = bookname,
                writerName = writername,
                language = language,
                country = country,
                price = price,
                numberofbookssold = numberofbookssold,
                coverImage = coverimage
            };
            flpListBookAdmin.Controls.Add(w);
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
