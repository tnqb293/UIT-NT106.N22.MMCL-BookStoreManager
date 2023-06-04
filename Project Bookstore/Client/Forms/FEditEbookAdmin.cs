using Client.Class;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FEditEbookAdmin : Form
    {
        private static string bookName;
        private InfoBook infobook { get; set; }
        internal IpConnection ipConnection = new IpConnection();
        private static string fileImage { get; set; }
        public FEditEbookAdmin(string bookname)
        {
            bookName = bookname;
            InitializeComponent();
        }
        public Image byteToImage(byte[] bytesPicture)
        {
            using (MemoryStream ms = new MemoryStream(bytesPicture))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        private void FEditEbookAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                infobook = new InfoBook();
                StringBuilder builder = ipConnection.ConnectToServer("request|findabook " + bookName);
                infobook = JsonConvert.DeserializeObject<InfoBook>(builder.ToString());
                tbBookName.Text = infobook.bookname;
                tbWriterName.Text = infobook.writername;
                tbLanguage.Text = infobook.language;
                tbCountry.Text = infobook.country;
                tbPriceAddBook.Text = infobook.price.ToString();
                tbPageNumber.Text = infobook.pagenumber.ToString();
                tbISBN.Text = infobook.isbn;
                tbYearOfPublication.Text = infobook.yearofpublication.ToString();
                tbIndex.Text = infobook.index;
                tbSummary.Text = infobook.summary;
                pbImageBook.Image = byteToImage(infobook.coverImage);
            }
            catch
            {
                this.Invoke(new Action(() => MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                infobook = new InfoBook();
                infobook.bookname = tbBookName.Text;
                infobook.writername = tbWriterName.Text;
                infobook.language = tbLanguage.Text;
                infobook.country = tbCountry.Text;
                infobook.price = Int32.Parse(tbPriceAddBook.Text);
                infobook.pagenumber = Int32.Parse(tbPageNumber.Text);
                infobook.coverImage = imageToBytes(pbImageBook.Image);
                infobook.isbn = tbISBN.Text;
                infobook.summary = tbSummary.Text;
                infobook.index = tbIndex.Text;
                infobook.yearofpublication = Int32.Parse(tbYearOfPublication.Text);
                infobook.numberofbookssold = 0;
                if (tbBookName != null && string.IsNullOrEmpty(tbBookName.Text)
                || tbWriterName != null && string.IsNullOrEmpty(tbWriterName.Text)
                || tbLanguage != null && string.IsNullOrEmpty(tbLanguage.Text)
                || tbCountry != null && string.IsNullOrEmpty(tbCountry.Text)
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
                        string message = "request|editbook " + bookName + "request|editbook " + JsonConvert.SerializeObject(infobook);
                        StringBuilder builder = ipConnection.ConnectToServer(message);
                        if (builder.ToString() == "edit successfully")
                        {
                            this.Invoke(new Action(() => MessageBox.Show("Thêm sách thành công")));
                        }
                        else if (builder.ToString() == "Error from server")
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
            catch
            {
                this.Invoke(new Action(() => MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)));
            }
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png;)|*.BMP;*JPG;*JPEG;*.PNG;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbImageBook.Image = Image.FromFile(ofd.FileName);
                fileImage = ofd.FileName;
            }
        }
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

        public Image resizeImage(Image img, int width, int height)
        {
            Bitmap b = new Bitmap(width, height);
            Graphics g = Graphics.FromImage((Image)b);
            g.DrawImage(img, 0, 0, width, height);
            g.Dispose();
            return (Image)b;
        }
    }
}
