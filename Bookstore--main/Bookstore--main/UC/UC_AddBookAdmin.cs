using Bookstore__main.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore__main.UC
{
    public partial class cbCategory_AddBook : UserControl
    {
        public cbCategory_AddBook()
        {
            InitializeComponent();
        }

        private void btnUploadPicture_AddBook_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*png)|*.BMP;*.JPG;*.JEPG;*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbImageBook__AddBook.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnAddBook_AddBook_Click(object sender, EventArgs e)
        {
            string BookName = tbName_AddBook.Text;
            string WriterName = tbAuthorName_AddBook.Text;
            string NationBook = tbNationAddBook.Text;
            decimal PriceBook = decimal.Parse(tbPrice_AddBook.Text);
            int QuantityBook = int.Parse(tbQuantity_AddBook.Text);
            string CategoryBook = tbCategory_Addbook.Text;
            Image PictureBook = pbImageBook__AddBook.Image;
            AddBook addBook = new AddBook();
            addBook.addBook(BookName, WriterName, NationBook, PriceBook, QuantityBook, CategoryBook, PictureBook);
            

        }
    }
}
