using Bookstore__main.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore__main.FormsBookstore
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnDashboardPanel_Click(object sender, EventArgs e)
        {
            UC_DashboardAdmin uc = new UC_DashboardAdmin();
            addUserControl(uc);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnContentAdmin.Controls.Clear();
            pnContentAdmin.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDashboardPanel_Click_2(object sender, EventArgs e)
        {
            UC_DashboardAdmin uC_Dashboard = new UC_DashboardAdmin();
            addUserControl(uC_Dashboard);
        }

        private void btnListBookPanel_Click_1(object sender, EventArgs e)
        {
            UC_ListBookAdmin uc = new UC_ListBookAdmin();
            addUserControl(uc);
        }

        private void btnAddBookPanel_Click(object sender, EventArgs e)
        {
            UC_AddBookAdmin uC_AddBook = new UC_AddBookAdmin();
            addUserControl(uC_AddBook);
        }

        private void btnListUserPanel_Click(object sender, EventArgs e)
        {
            UC_ListUserAdmin uc = new UC_ListUserAdmin();
            addUserControl(uc);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
