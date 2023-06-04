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
                StringBuilder builder = ipConnection.ConnectToServer("request|findabook " + infobuybook.bookname);
                infobook = JsonConvert.DeserializeObject<InfoBook>(builder.ToString());
                lbMoneyBook.Text = infobook.price.ToString() + " VND";
                //rtbContent.Lines[0] = "Tên sách: " + infobook.bookname;
                //rtbContent.Lines[1] = "Tác giả: " + infobook.writername;
                //rtbContent.Lines[2] = "Năm xuất bản: 2019";
                //rtbContent.Lines[3] = "Quốc gia: " + infobook.country;
                //rtbContent.Lines[4] = "Số trang: " + infobook.pagenumber.ToString();
                //rtbContent.Lines[5] = "ISBN: " + infobook.isbn;
                //rtbContent.Lines[6] = "Mục luc: \n" + infobook.index;
                //rtbContent.Lines[7] = "Tóm tắt: \n" + infobook.summary;
                string data = "Tên sách: " + infobook.bookname + "\rTên tác giả: " + infobook.writername
                    + "\rNăm xuất bản: " + infobook.yearofpublication.ToString() + "\rQuốc gia: " + infobook.country + "\rSố trang: " + infobook.pagenumber.ToString()
                    + "\rISBN: " + infobook.isbn + "\rMục luc: \r" + infobook.index + "\rTóm tắt: \r" + infobook.summary;
                rtbContent.Text = data;
                //rtbContent.SelectAll();
                //rtbContent.SelectionAlignment = HorizontalAlignment.Center;
                pbCoverImage.Image = byteToImage(infobook.coverImage);
            }
            catch
            {
                this.Invoke(new Action(() => MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)));
            }
        }

        
        private void btnBuy_Click(object sender, EventArgs e)
        {
            infobuybook.datetime = DateTime.Now;
            string message = "request|buybook " + JsonConvert.SerializeObject(infobuybook);
            StringBuilder builder = ipConnection.ConnectToServer(message);
            string data = builder.ToString();
            string[] splitData =  data.Split(',');
            if (splitData[0].ToString() == "Purchase success")
            {
                FMainCustomer.instance.lbtext.Text = splitData[1];
                UCListBookCustomer form = new UCListBookCustomer(infobuybook.username);
                form.Refresh();
                this.Invoke(new Action(() => MessageBox.Show("Mua sách thành công!")));
            }
            else if (builder.ToString() == "Not enough money")
                this.Invoke(new Action(() => MessageBox.Show("Mua sách thất bại! Vui lòng kiểm tra số dư!")));
            else if (builder.ToString() == "Already own")
                this.Invoke(new Action(() => MessageBox.Show($"Sách {infobuybook.bookname} đã sở hữu")));
            else
                this.Invoke(new Action(() => MessageBox.Show("Lỗi từ phía máy chủ!")));
        }
    }
}
