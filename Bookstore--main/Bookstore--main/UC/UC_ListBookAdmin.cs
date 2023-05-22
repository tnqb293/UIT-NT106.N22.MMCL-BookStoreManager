using Bookstore__main.Class;
using System;
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
using static Bookstore__main.UC.UC_ListBookAdmin;

namespace Bookstore__main.UC
{
    public partial class UC_ListBookAdmin : UserControl
    {
        public event EventHandler OnSelect = null;

        public UC_ListBookAdmin()
        {
            InitializeComponent();
        }
        List<ItemBook> itemBook = new List<ItemBook>();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OJKQD5I\SQLEXPRESS;Initial Catalog=DBBookstore;Integrated Security=True");
        private void UC_ListBook_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select BookName, WriterName, NationBook, PriceBook, QuantityBook, CategoryBook, Image from BookInfo", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ItemBook book = new ItemBook();
                    book.BookName = reader.GetString(0);
                    book.WriterName = reader.GetString(1);
                    book.NationBook = reader.GetString(2);
                    book.PriceBook = reader.GetDecimal(3);
                    book.QuantityBook = reader.GetInt32(4);
                    book.CategoryBook = reader.GetString(5);
                    byte[] imageBytes = (byte[])reader["Image"];
                    MemoryStream ms = new MemoryStream(imageBytes);
                    book.PictureBook = Image.FromStream(ms);
                    itemBook.Add(book);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
    
            foreach (ItemBook book in itemBook)
            {
                AddItems(book.BookName, book.WriterName, book.NationBook, book.PriceBook, book.QuantityBook, book.CategoryBook, book.PictureBook);
            }

            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
        }
        private void AddItems(string bookname, string writename, string nationbook, decimal pricebook, int quantitybook, string categorybook, Image image)
        {
            var w = new UC_ItemListBookAdmin()
            {
                bookName = bookname,
                writerName = writename,
                nationBook = nationbook,
                priceBook = pricebook,
                quantityBook = quantitybook,
                categoryBook = categorybook,
                pictureBook = image
            };
            flowLayoutPanel1.Controls.Add(w);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2Button13_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
