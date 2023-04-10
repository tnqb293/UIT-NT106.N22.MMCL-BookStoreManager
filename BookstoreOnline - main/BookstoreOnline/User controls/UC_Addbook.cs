using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookstoreOnline.User_controls
{
    public partial class UC_Addbook : UserControl
    {
        public UC_Addbook()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=DESKTOP-OJKQD5I\SQLEXPRESS;Initial Catalog=BookstoreDB;Integrated Security=True";
        private void btnUploadPicture_AddBook_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*png)|*.BMP;*.JPG;*.JEPG;*.PNG";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pbImageBook__AddBook.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnAddBook_AddBook_Click(object sender, EventArgs e)
        {
            string bookName = tbName_AddBook.Text;
            string authorName = tbAuthorName_AddBook.Text;
            string nationBook = tbNationAddBook.Text;
            int  priceBook =  int.Parse(tbPrice_AddBook.Text);
            int quantityBook = int.Parse(tbQuantity_AddBook.Text);
            string categoryBook = cbCategory_AddBook.Text;
            if (string.IsNullOrEmpty(bookName) || string.IsNullOrEmpty(authorName) || string.IsNullOrEmpty(nationBook)
                || string.IsNullOrEmpty(tbPrice_AddBook.Text) || string.IsNullOrEmpty(tbQuantity_AddBook.Text) || string.IsNullOrEmpty(categoryBook))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin quyển sách bạn muốn thêm vào.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO Table_Book (Bookname, Authorname, Category, Nation, Price, Quantity, Image) VALUES (@bookName, @authorName, @categoryBook, @nationBook, @priceBook, @quantityBook, @ImageData)";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@bookName", bookName);
            cmd.Parameters.AddWithValue("@authorName", authorName);
            cmd.Parameters.AddWithValue("@categoryBook", categoryBook);
            cmd.Parameters.AddWithValue("@nationBook", nationBook);
            cmd.Parameters.AddWithValue("@priceBook", priceBook);
            cmd.Parameters.AddWithValue("@quantityBook", quantityBook);
            SqlParameter param = new SqlParameter("@ImageData", SqlDbType.Image);
            MemoryStream ms = new MemoryStream();
            pbImageBook__AddBook.Image.Save(ms, pbImageBook__AddBook.Image.RawFormat);
            byte[] imageData = ms.GetBuffer();
            param.Value = imageData;
            cmd.Parameters.Add(param);
            int result = cmd.ExecuteNonQuery();
            if(result > 0)
                MessageBox.Show("Thêm sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm sách thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
