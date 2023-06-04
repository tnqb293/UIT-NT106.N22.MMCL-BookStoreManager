using Client.Forms;
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
    public partial class UCItemReadBookCustomer : UserControl
    {
        static string userName;
        public UCItemReadBookCustomer(string username)
        {
            InitializeComponent();
            userName = username;
        }
        internal string bookName
        {
            get { return lbBookName.Text; }
            set { lbBookName.Text = value; }
        }
        internal string writername
        {
            get { return lbWriterName.Text; }
            set { lbWriterName.Text = value;}
        }
        internal string country
        {
            get { return lbCountry.Text; }
            set { lbCountry.Text = value; }
        }
        internal string language
        {
            get { return lbLanguage.Text; }
            set { lbLanguage.Text = value; }
        }
        internal int price
        {
            get { return Int32.Parse(lbMoney.Text); }
            set { lbMoney.Text = value.ToString() + " VND"; }
        }
        internal int numberofbookssold
        {
            get { return Int32.Parse(lbNumberOfBookRemaining.Text); }
            set { lbNumberOfBookRemaining.Text = "Sách đã bán: " + value.ToString(); }
        }
        internal Image coverImage
        {
            get { return pbCoverImage.Image; }
            set { pbCoverImage.Image = value; }
        }

        private void btnReadBook_Click(object sender, EventArgs e)
        {
            Form Freadbook = new FReadBookCustomer();
            Freadbook.Show();
        }
    }
}
