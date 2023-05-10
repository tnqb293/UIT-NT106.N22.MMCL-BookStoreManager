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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void btnDashboardPanelUser_Click(object sender, EventArgs e)
        {
            UC_DashboardUser uC_Dashboard = new UC_DashboardUser();
            addUserControl(uC_Dashboard);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnContentUser.Controls.Clear();
            pnContentUser.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnListBookPanelUser_Click(object sender, EventArgs e)
        {
            UC_ListBookUser uc = new UC_ListBookUser();
            addUserControl(uc);
        }

        private void btnAddBookPanelUser_Click(object sender, EventArgs e)
        {

        }

        private void btnShoppingCartPanelUser_Click(object sender, EventArgs e)
        {
            UC_ShopingCartUser uc = new UC_ShopingCartUser();
            addUserControl(uc);
        }

        private void btnPurchaseHistoryPanelUser_Click(object sender, EventArgs e)
        {
            UC_PurchaseHistoryUser uc = new UC_PurchaseHistoryUser();
            addUserControl(uc);
        }

        private void btnSettingPanelUser_Click(object sender, EventArgs e)
        {
            UC_SettingUser uc = new UC_SettingUser();
            addUserControl(uc);
        }

        private void pnContentUser_Paint(object sender, PaintEventArgs e)
        {
            UC_DashboardUser uC_Dashboard = new UC_DashboardUser();
            addUserControl(uC_Dashboard);
        }
    }
}
