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
        private IpConnection ipConnection = new IpConnection();
        private Thread receiveThread { get; set; }
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
                string message = "itembook";
                StringBuilder builder = ipConnection.messageFromServer(message);
                string data = builder.ToString();
                infobookList = JsonConvert.DeserializeObject<List<InfoBookList>>(data);
                foreach (InfoBookList book in infobookList)
                {
                    AddItem(book.bookname, book.writername, book.country, book.category, book.price, book.numberOfBookRemaining, stringToImage(book.coverImage));
                }
                receiveThread = new Thread(new ThreadStart(ipConnection.receiveMessage));
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
            catch
            {
                this.Invoke(new Action(() => MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)));
            }
        }
        private void AddItem(string bookname, string writername, string country, string category, int price, int numberofbookremaining, Image coverimage)
        {
            var w = new UCItemListBookAdmin()
            {
                bookName = bookname,
                writerName = writername,
                category = category,
                country = country,
                price = price,
                numberOfBookRemaining = numberofbookremaining,
                coverImage = coverimage
            };
            flpListBookAdmin.Controls.Add(w);
        }
        public Image stringToImage(string picture)
        {
            byte[] imageBytes = Convert.FromBase64String(picture);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }
    }
}
