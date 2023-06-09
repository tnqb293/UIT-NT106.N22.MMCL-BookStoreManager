﻿using Client.Forms;
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
        // Các biến bookName, country, writerName, language, price, numberofbooksold, coverImage sẽ được gán giá trị từ 
        // get và lưu giá trị vào biến value cuối cùng gán chúng vào các lb tương ứng
        internal string bookName
        {
            get { return lbBookName.Text; }
            set { lbBookName.Text = value; }
        }
        internal string country
        {
            get { return lbCountry.Text; }
            set { lbCountry.Text = "Quốc gia: " + value; }
        }
        internal string writerName
        {
            get { return lbWriterName.Text; }
            set { lbWriterName.Text = value; }
        }
        internal string language
        {
            get { return lbLanguage.Text; }
            set { lbLanguage.Text = "Ngôn ngữ: " + value; }
        }
        internal int price
        {
            get { return Int32.Parse(lbMoney.Text); }
            set { lbMoney.Text = value.ToString() + " VND"; }
        }
        internal int numberofbookssold
        {
            get { return Int32.Parse(lbNumberOfBookRemaining.Text); }
            set { lbNumberOfBookRemaining.Text = "Đã bán: " + value.ToString(); }
        }
        internal Image coverImage
        {
            get { return pbCoverImage.Image; }
            set { pbCoverImage.Image = value; }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FEditEbookAdmin form = new FEditEbookAdmin(bookName);
            form.ShowDialog();
        }
    }
}
