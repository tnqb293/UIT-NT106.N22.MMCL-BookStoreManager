using BookstoreOnline.User_controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreOnline.Forms
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pn_Container.Controls.Clear();
            pn_Container.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnDashboardPanel_Click(object sender, EventArgs e)
        {
            UC_Dashboard uc = new UC_Dashboard();
            addUserControl(uc);
        }

        private void btnBookPanel_Click(object sender, EventArgs e)
        {
            UC_Book uc = new UC_Book();
            addUserControl(uc);
        }

        private void btnCartPanel_Click(object sender, EventArgs e)
        {
            UC_Cart uc = new UC_Cart();
            addUserControl(uc);
        }

        private void User_Load(object sender, EventArgs e)
        {
            UC_Dashboard uc = new UC_Dashboard();
            addUserControl(uc);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            UC_Addbook uc = new UC_Addbook();
            addUserControl(uc);
        }
    }
}
