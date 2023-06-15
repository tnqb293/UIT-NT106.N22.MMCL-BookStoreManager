using Client.Class;
using Client.UC;
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
namespace Client.Forms
{
    public partial class FVerifyBuyBook : Form
    {
        static InfoBuyBook infobuybook = new InfoBuyBook();
        internal IpConnection ipConnection = new IpConnection();

        //------------------------------
        public static FVerifyBuyBook instance;

        //-------------------------------
        // Biến instance dùng để cập nhật tiền của người dùng ngay khi tiền tăng hoặc giảm
        // mà không phải load lại form
        public FVerifyBuyBook(string bookname, string username)
        {
            infobuybook.bookname = bookname;
            infobuybook.username = username;
            instance = this;
            InitializeComponent();
        }
        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // Chuyển kiểu Image sang kiểu byte
        public Image byteToImage(byte[] bytesPicture)
        {
            using (MemoryStream ms = new MemoryStream(bytesPicture))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FVerifyBuyBook_Load_1(object sender, EventArgs e)
        {
            try
            {
                InfoBook infobook = new InfoBook();
                //Gửi yêu cầu tới server bằng hàm ConnectToServer và lưu lại phản hồi từ server
                // vào biến builder
                StringBuilder builder = ipConnection.ConnectToServer("request|findabook " + infobuybook.bookname);
                // Giải nén đối tượng InfoBook mà server phản hồi
                infobook = JsonConvert.DeserializeObject<InfoBook>(builder.ToString());
                lbMoneyBook.Text = infobook.price.ToString() + " VND";
                string data = "Tên sách: " + infobook.bookname + "\rTên tác giả: " + infobook.writername
                    + "\rNăm xuất bản: " + infobook.yearofpublication.ToString() + "\rQuốc gia: " + infobook.country + "\rSố trang: " + infobook.pagenumber.ToString()
                    + "\rISBN: " + infobook.isbn + "\rMục luc: \r" + infobook.index + "\rTóm tắt: \r" + infobook.summary;
                // Hiển thị dữ liệu sang richtextbox
                rtbContent.Text = data;
                // Chuyển kiểu byte sang image
                pbCoverImage.Image = byteToImage(infobook.coverImage);
            }
            catch
            {
                this.Invoke(new Action(() => MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)));
            }
        }

        
        private void btnBuy_Click(object sender, EventArgs e)
        {
            // Lấy giá trị giờ hiện tại lưu vào biến infobuybook.datetime
            infobuybook.datetime = DateTime.Now;
            // biến message sẽ lưu trữ 1 chuỗi đã đóng với Json bởi vì infobuybook có rất nhiều thuộc tính
            string message = "request|buybook " + JsonConvert.SerializeObject(infobuybook);
            //Gửi yêu cầu tới server bằng hàm ConnectToServer và lưu lại phản hồi từ server
            // vào biến builder
            StringBuilder builder = ipConnection.ConnectToServer(message);
            string data = builder.ToString();
            string[] splitData =  data.Split(',');
            if (splitData[0].ToString() == "Purchase success")
            {
                // Cập nhật giá trị tiền lên lbMoney mà không phải load lại form
                FMainCustomer.instance.lbtext.Text = splitData[1];
                UCListBookCustomer form = new UCListBookCustomer(infobuybook.username);
                form.Refresh();
                this.Invoke(new Action(() => MessageBox.Show("Mua sách thành công!")));
            }
            else if (builder.ToString() == "Not enough money")
                this.Invoke(new Action(() => MessageBox.Show("Mua sách thất bại! Vui lòng kiểm tra số dư!")));
            // Thông báo khi người dùng đã mua quyển sách đó rồi
            else if (builder.ToString() == "Already own")
                this.Invoke(new Action(() => MessageBox.Show($"Sách {infobuybook.bookname} đã sở hữu")));
            else
                this.Invoke(new Action(() => MessageBox.Show("Lỗi từ phía máy chủ!")));
        }
    }
}
