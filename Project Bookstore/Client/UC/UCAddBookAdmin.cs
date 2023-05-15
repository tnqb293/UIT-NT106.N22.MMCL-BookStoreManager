using Client.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UC
{
    public partial class UCAddBookAdmin : UserControl
    {
        InfoUser infoUser = new InfoUser();
        private InfoBook infoBook { get; set; }
        private IpConnection ipConnection = new IpConnection();
        public UCAddBookAdmin(string user)
        {
            InitializeComponent();
            infoUser.username = user;
        }

        private void btnUploadPicture_AddBook_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.BMP;*JPG;*JPEG;*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbImageBookAddBook.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnAddBookAddBook_Click(object sender, EventArgs e)
        {
            infoBook = new InfoBook();
            infoBook.bookname = tbBookNameAddBook.Text;
            infoBook.writername = tbWriterNameAddBook.Text;
            infoBook.category = cbCategoryAddBook.Text;
            infoBook.country = tbCountryAddBook.Text;
            infoBook.price = Int32.Parse(tbPriceAddBook.Text);
            infoBook.numberOfBookRemaining = Int32.Parse(tbNumberOfBookRemainingAddBook.Text);
            infoBook.coverImage = pbImageBookAddBook.Image;
            if (tbBookNameAddBook != null && string.IsNullOrEmpty(tbBookNameAddBook.Text)
                || tbWriterNameAddBook != null && string.IsNullOrEmpty(tbWriterNameAddBook.Text)
                || cbCategoryAddBook != null && string.IsNullOrEmpty(cbCategoryAddBook.Text)
                || tbCountryAddBook != null && string.IsNullOrEmpty(tbCountryAddBook.Text)
                || tbPriceAddBook != null && string.IsNullOrEmpty(tbPriceAddBook.Text)
                || tbNumberOfBookRemainingAddBook != null && string.IsNullOrEmpty(tbNumberOfBookRemainingAddBook.Text))
            {
                this.Invoke(new Action(() => MessageBox.Show("Vui lòng nhập đủ thông tin")));
                return;
            }
            else
            {
                try
                {
                    string message = infoBook.bookname + "  " + infoBook.writername + "  " + infoBook.category + "  " +
                    infoBook.country + "  " + infoBook.price.ToString() + "  " + infoBook.numberOfBookRemaining.ToString() + "  " +  ImageToString(infoBook.coverImage) + "  addbook";
                    StringBuilder builder = ipConnection.messageFromServer(message);
                    if (builder.ToString() == "add book success")
                    {
                        infoBook.receiveThread = new Thread(new ThreadStart(ipConnection.receiveMessage));
                        infoBook.receiveThread.IsBackground = true;
                        infoBook.receiveThread.Start();
                        this.Invoke(new Action(() => MessageBox.Show("Thêm sách thành công")));
                    }
                    else if (builder.ToString() == "add book failed")
                    {
                        this.Invoke(new Action(() => MessageBox.Show("Thêm sách thất bại")));
                    }
                    else if (builder.ToString() == "Error")
                    {
                        this.Invoke(new Action(() => MessageBox.Show("Lỗi bên phía máy chủ")));
                    }
                }
                catch
                {
                    this.Invoke(new Action(() => MessageBox.Show($"Không tìm thấy máy chủ {ipConnection.ipAddr}.")));
                }

            }
        }
        private string ImageToString(Image coverBook)
        {
            byte[] imageBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                coverBook.Save(ms, coverBook.RawFormat);
                imageBytes = ms.ToArray();
            }
            string imageString = Convert.ToBase64String(imageBytes);
            return imageString;
        }
    }
}