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
            UC_Dashboard uc = new UC_Dashboard();
            addUserControl(uc);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnContent.Controls.Clear();
            pnContent.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddBookPanel_Click_1(object sender, EventArgs e)
        {
            UC_AddBook uC_AddBook = new UC_AddBook();
            addUserControl(uC_AddBook);
        }

        private void btnDashboardPanel_Click_1(object sender, EventArgs e)
        {
            UC_Dashboard uC_Dashboard = new UC_Dashboard();
            addUserControl(uC_Dashboard);
        }

        private void btnListBookPanel_Click(object sender, EventArgs e)
        {
            UC_ListBook uc = new UC_ListBook();
            addUserControl(uc);
        }

        private void btnListAdmin_Click(object sender, EventArgs e)
        {
            UC_ListUser uc = new UC_ListUser();
            addUserControl(uc);

        }
    }
}
