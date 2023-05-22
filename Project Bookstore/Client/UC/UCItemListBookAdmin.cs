using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UC
{
    public partial class UCItemListBookAdmin : UserControl
    {
        public UCItemListBookAdmin()
        {
            InitializeComponent();
        }
        internal string bookName
        {
            get { return lbBookName.Text; }
            set { lbBookName.Text = value; }
        }
        internal string country
        {
            get { return lbCountry.Text; }
            set { lbCountry.Text = value; }
        }
        internal string writerName
        {
            get { return lbWriterName.Text; }
            set { lbWriterName.Text = value; }
        }
        internal string category
        {
            get { return lbCategory.Text; }
            set { lbCategory.Text = value; }
        }
        internal int price
        {
            get { return Int32.Parse(lbMoney.Text); }
            set { lbMoney.Text = value.ToString() + " VND"; }
        }
        internal int numberOfBookRemaining
        {
            get { return Int32.Parse(lbNumberOfBookRemaining.Text); }
            set { lbNumberOfBookRemaining.Text = "Số lượng còn lại: " + value.ToString(); }
        }
        internal Image coverImage
        {
            get { return pbCoverImage.Image; }
            set { pbCoverImage.Image = value; }
        }
    }
}
