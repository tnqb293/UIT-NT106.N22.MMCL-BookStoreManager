using Client.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UC
{
    public partial class UCListBookAdmin : UserControl
    {
        internal class Infobook
        {
            internal string bookname { get; set; }
            internal string writername { get; set; }
            internal string category { get; set; }
            internal string country { get; set; }
            internal int price { get; set; }
            internal int numberOfBookRemaining { get; set; }
            internal string coverImage { get; set; }
        }
        InfoUser infoUser = new InfoUser();
        private IpConnection ipConnection = new IpConnection();
        private ThreadExceptionDialog recieveThread { get; set; }

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
                BinaryFormatter formatter = new BinaryFormatter();                
                string message = "itembook";
                List<Infobook> books = new List<Infobook>();
                StringBuilder builder = ipConnection.messageFromServer(message);
                byte[] byteArr = Encoding.Unicode.GetBytes(builder.ToString());
                MemoryStream ms = new MemoryStream(byteArr);
                List<Infobook> list2 = (List<Infobook>)formatter.Deserialize(ms);
                foreach( Infobook book in list2 )
                {
                    AddItem(book.bookname, book.writername, book.country, book.category, book.price, book.numberOfBookRemaining);
                }
                
            }
            catch
            {
                this.Invoke(new Action(() => MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)));
            }
        }
        private void AddItem(string bookname, string writername, string categorry, string country, int price, int numberofbookremaining)
        {
            var w = new UCItemListBookAdmin()
            {
                bookName = bookname,
                writerName = writername,
                category = categorry,
                country = country,
                price = price,
                numberOfBookRemaining = numberofbookremaining
                //coverImage = coverimage
            };
            flpListBookAdmin.Controls.Add(w);
        }
    }
}
