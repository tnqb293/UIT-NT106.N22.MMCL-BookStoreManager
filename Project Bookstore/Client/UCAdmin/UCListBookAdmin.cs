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
        InfoUser infoUser = new InfoUser();
        internal IpConnection ipConnection = new IpConnection();
        public UCListBookAdmin(string user)
        {
            InitializeComponent();
            infoUser.username = user;
        }

        private void UCListBookAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo danh sách với kiểu InfoBookList và biến infobookList
                List<InfoBookList> infobookList = new List<InfoBookList>();
                string message = "itembook " + infoUser.username;
                //Gửi yêu cầu tới server bằng hàm ConnectToServer và lưu lại phản hồi từ server
                // vào biến builder
                StringBuilder builder = ipConnection.ConnectToServer(message);
                string data = builder.ToString();
                // Giải nén biến data bằng json với List kiểu dữ liệu là InfoBookList
                infobookList = JsonConvert.DeserializeObject<List<InfoBookList>>(data);
                // Hiển thị danh sách các ebook
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
            // Sau khi gán các giá trị trên xong thì sẽ thêm 1 item vào flowLayoutPanel
            flpListBookAdmin.Controls.Add(w);
        }
        // Chuyển từ kiểu byte sang Image
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
