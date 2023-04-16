using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore__main.Class
{
    internal class AddBook
    {
        string connectionString = @"Data Source=LAPTOP-67KGLN6P\SQLEXPRESS;Initial Catalog=BookStoreManager;Integrated Security=True";
        public void addBook(string BookName, string WriterName, string NationBook, decimal PriceBook, int QuantityBook, string CategoryBook, Image PictureBook)
        {
            if (string.IsNullOrEmpty(BookName) || string.IsNullOrEmpty(WriterName) || string.IsNullOrEmpty(NationBook)
                || string.IsNullOrEmpty(PriceBook.ToString()) || string.IsNullOrEmpty(QuantityBook.ToString()) || string.IsNullOrEmpty(CategoryBook))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin quyển sách bạn muốn thêm vào.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "insert into BookInfo (BookName, WriterName, NationBook, PriceBook, QuantityBook, CategoryBook, Image) values (@BookName, @WriterName, @NationBook, @PriceBook, @QuantityBook, @CategoryBook, @Image)";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@BookName", BookName);
            cmd.Parameters.AddWithValue("@WriterName", WriterName);
            cmd.Parameters.AddWithValue("@NationBook", NationBook);
            cmd.Parameters.AddWithValue("@PriceBook", PriceBook);
            cmd.Parameters.AddWithValue("@QuantityBook", QuantityBook);
            cmd.Parameters.AddWithValue("@CategoryBook", CategoryBook);
            SqlParameter param = new SqlParameter("@Image", SqlDbType.Image);
            MemoryStream ms = new MemoryStream();
            PictureBook.Save(ms, ImageFormat.Jpeg);
            byte[] imageData = ms.GetBuffer();
            param.Value = imageData;
            cmd.Parameters.Add(param);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
                MessageBox.Show("Thêm sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Thêm sách thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
