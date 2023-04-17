using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore__main.UC
{
    public partial class UC_ItemListBookAdmin : UserControl
    {
        public UC_ItemListBookAdmin()
        {
            InitializeComponent();
        }

        private void nameAuthor_Click(object sender, EventArgs e)
        {

        }
        public string bookName
        {
            get { return BookName.Text; }
            set { BookName.Text = value; }
        }
        public string writerName
        {
            get { return WriterName.Text; }
            set { WriterName.Text = value; }
        }
        public Image pictureBook
        {
            get { return PictureBook.Image; }
            set { PictureBook.Image = value; }
        }
        public string nationBook
        {
            get { return NationBook.Text; }
            set { NationBook.Text = value; }
        }
        public int quantityBook { get; set; }
        public decimal priceBook { get; set; }
        public string categoryBook
        {
            get { return CategoryBook.Text; }
            set { CategoryBook.Text = value; }
        }
    }
}
