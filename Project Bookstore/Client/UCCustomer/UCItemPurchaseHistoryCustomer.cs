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
    public partial class UCItemPurchaseHistoryCustomer : UserControl
    {
        static string userName;
        public UCItemPurchaseHistoryCustomer(string username)
        {
            InitializeComponent();
            userName = username;
        }
        internal int tradingcode
        {
            get { return Int32.Parse(lbTradingCode.Text); }
            set { lbTradingCode.Text = value.ToString(); }
        }
        internal string bookname
        {
            get { return lbbookname.Text; }
            set { lbbookname.Text = value; }
        }
        internal int price
        {
            get { return Int32.Parse(lbPrice.Text); }
            set { lbPrice.Text = value.ToString(); }
        }
        internal DateTime datetime
        {
            get { return DateTime.Parse(lbDatetime.Text); }
            set { lbDatetime.Text = value.ToString(); }
        }
        internal int getpoints
        {
            get { return Int32.Parse(lbGetPoints.Text); }
            set { lbGetPoints.Text = value.ToString(); }
        }
        internal Image imagecover
        {
            get { return pbImageCover.Image; }
            set { pbImageCover.Image = value; }
        }
    }
}
