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
        private bool isSearching = false;
        public event EventHandler OnSelect = null;

        public UC_ListBookAdmin()
        {
            InitializeComponent();
        }
        List<ItemBook> itemBook = new List<ItemBook>();
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-5OR18CU3;Initial Catalog=DBBookstore;Integrated Security=True");
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
        private void SearchBooks(string bookName)
        {
            // Clear the itemBook list to remove previous search results
            itemBook.Clear();

            // Xóa các sách đang hiển thị trên UC_ListBook
            flowLayoutPanel1.Controls.Clear();

            try
            {
                // Tạo câu lệnh SQL để lấy các sách có tên tương ứng
                SqlCommand cmd = new SqlCommand("SELECT BookName, WriterName, NationBook, PriceBook, QuantityBook, CategoryBook, Image FROM BookInfo WHERE BookName LIKE @BookName", conn);
                cmd.Parameters.AddWithValue("@BookName", "%" + bookName + "%");

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

            // Hiển thị các sách tìm kiếm được trên UC_ListBook
            foreach (ItemBook book in itemBook)
            {
                AddItems(book.BookName, book.WriterName, book.NationBook, book.PriceBook, book.QuantityBook, book.CategoryBook, book.PictureBook);
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        

        

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

       

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string bookName = txtSearch.Text.Trim();
            SearchBooks(bookName);
            isSearching = true;
        }
        private void UpdateBookList()
        {
            // Clear the flow layout panel
            flowLayoutPanel1.Controls.Clear();

            // Add the sorted books to the flow layout panel
            foreach (ItemBook book in itemBook)
            {
                AddItems(book.BookName, book.WriterName, book.NationBook, book.PriceBook, book.QuantityBook, book.CategoryBook, book.PictureBook);
            }
        }
        private void SortBooksByNameAsc()
        {
            itemBook = itemBook.OrderBy(b => b.BookName).ToList();
            UpdateBookList();
        }

        private void SortBooksByNameDesc()
        {
            itemBook = itemBook.OrderByDescending(b => b.BookName).ToList();
            UpdateBookList();
        }

        private void btnAZ_Click(object sender, EventArgs e)
        {
            SortBooksByNameAsc();
        }

        private void btnZA_Click(object sender, EventArgs e)
        {
            SortBooksByNameDesc();
        }
        private void SortBooksByPrice(bool isDescending)
        {
            if (isSearching)
            {
                itemBook.Sort((x, y) => isDescending ? y.PriceBook.CompareTo(x.PriceBook) : x.PriceBook.CompareTo(y.PriceBook));
            }
            else
            {
                List<ItemBook> sortedBooks = itemBook.OrderBy(book => book.PriceBook).ToList();
                if (isDescending)
                {
                    sortedBooks.Reverse();
                }
                itemBook = sortedBooks;
            }

            UpdateBookList();
        }

        private void btnSortByPriceAsc_Click(object sender, EventArgs e)
        {
            SortBooksByPrice(true);
        }

        private void btnSortByPriceDesc_Click(object sender, EventArgs e)
        {
            SortBooksByPrice(false);
        }
    }
}
