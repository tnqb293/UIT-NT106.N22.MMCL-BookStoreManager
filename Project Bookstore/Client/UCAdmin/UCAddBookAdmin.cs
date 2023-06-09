﻿using Client.Class;
using Newtonsoft.Json;
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
using Encoder = System.Drawing.Imaging.Encoder;
namespace Client.UC
{
    public partial class UCAddBookAdmin : UserControl
    {
        InfoUser infoUser = new InfoUser();
        private static string fileImage { get; set; }
        private InfoBook infoBook { get; set; }
        private IpConnection ipConnection = new IpConnection();
        //Lấy tên của người dùng ở FMainAdmin và gán vào biến infoUser.username
        public UCAddBookAdmin(string user)
        {
            InitializeComponent();
            infoUser.username = user;
        }

        private void btnUploadPicture_AddBook_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            // Mở dialog lên và chọn hình theo các định dạng .bmp, .jpg, .jpeg, .png
            ofd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png;)|*.BMP;*JPG;*JPEG;*.PNG;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbImageBookAddBook.Image = Image.FromFile(ofd.FileName);
                fileImage = ofd.FileName;
            }
        }

        private void btnAddBookAddBook_Click(object sender, EventArgs e)
        {
            infoBook = new InfoBook();
            //Lấy các giá trị từ các textbox tương ứng
            infoBook.bookname = tbBookNameAddBook.Text;
            infoBook.writername = tbWriterNameAddBook.Text;
            infoBook.language = tbLanguage.Text;
            infoBook.country = tbCountryAddBook.Text;
            infoBook.price = Int32.Parse(tbPriceAddBook.Text);
            infoBook.pagenumber = Int32.Parse(tbPageNumber.Text);
            infoBook.coverImage = imageToBytes(pbImageBookAddBook.Image);
            infoBook.isbn = tbISBN.Text;
            infoBook.summary = tbSummary.Text;
            infoBook.index = tbIndex.Text;
            infoBook.yearofpublication = Int32.Parse(tbYearOfPublication.Text);
            infoBook.numberofbookssold = 0;
            // Kiểm tra xem người dùng đã nhập đủ thông tin chưa
            if (tbBookNameAddBook != null && string.IsNullOrEmpty(tbBookNameAddBook.Text)
                || tbWriterNameAddBook != null && string.IsNullOrEmpty(tbWriterNameAddBook.Text)
                || tbLanguage != null && string.IsNullOrEmpty(tbLanguage.Text)
                || tbCountryAddBook != null && string.IsNullOrEmpty(tbCountryAddBook.Text)
                || tbPriceAddBook != null && string.IsNullOrEmpty(tbPriceAddBook.Text)
                || tbPageNumber != null && string.IsNullOrEmpty(tbPageNumber.Text)
                || tbISBN != null && string.IsNullOrEmpty(tbISBN.Text)
                || tbIndex != null && string.IsNullOrEmpty(tbIndex.Text)
                || tbSummary != null && string.IsNullOrEmpty(tbSummary.Text)
                || tbYearOfPublication != null && string.IsNullOrEmpty(tbYearOfPublication.Text))
            {
                this.Invoke(new Action(() => MessageBox.Show("Vui lòng nhập đủ thông tin")));
                return;
            }
            else
            {
                try
                {
                    // Đóng gói biến infobook bằng json rồi lưu vào biến message
                    string message = "request|addbook " + JsonConvert.SerializeObject(infoBook);
                    //Gửi yêu cầu tới server bằng hàm ConnectToServer và lưu lại phản hồi từ server
                    // vào biến builder
                    StringBuilder builder = ipConnection.ConnectToServer(message);
                    if (builder.ToString() == "add book success")
                    {
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
                    this.Invoke(new Action(() => MessageBox.Show($"Không tìm thấy máy chủ.")));
                }

            }
        }
        // Chuyển kiểu Image sang kiểu Bytes
        private byte[] imageToBytes(Image coverBook)
        {
            byte[] imageBytes;
            Image reduceImage = resizeImage(coverBook, 474, 673);
            using (MemoryStream ms = new MemoryStream())
            {
                reduceImage.Save(ms, ImageFormat.Jpeg);
                imageBytes = ms.ToArray();
            }
            return imageBytes;
        }
        // Giảm kích thước hình ảnh nếu ảnh vượt quá kích thước quy định
        public Image resizeImage(Image img, int width, int height)
        {
            Bitmap b = new Bitmap(width, height);
            Graphics g = Graphics.FromImage((Image)b);
            g.DrawImage(img, 0, 0, width, height);
            g.Dispose();
            return (Image)b;
        }

        private void pbImageBookAddBook_Click(object sender, EventArgs e)
        {

        }
    }
}