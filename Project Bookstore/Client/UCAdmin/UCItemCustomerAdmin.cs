using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UCAdmin
{
    public partial class UCItemCustomerAdmin : UserControl
    {
        public UCItemCustomerAdmin()
        {
            InitializeComponent();
        }
        internal int idCustomer
        {
            get { return Int32.Parse(lbIdCustomer.Text); }
            set { lbIdCustomer.Text = value.ToString(); }
        }
        internal string nameCustomer
        {
            get { return lbnamecustomer.Text; }
            set { lbnamecustomer.Text = value; }
        }
        internal int money
        {
            get { return Int32.Parse(lbMoney.Text); }
            set { lbMoney.Text = value.ToString(); }
        }
        internal int getPoints
        {
            get { return Int32.Parse(lbGetPoints.Text); }
            set { lbGetPoints.Text = value.ToString(); }
        }
        internal DateTime datetime
        {
            get { return DateTime.Parse(lbDatetime.Text); }
            set { lbDatetime.Text = value.ToString(); }
        }
    }
}
