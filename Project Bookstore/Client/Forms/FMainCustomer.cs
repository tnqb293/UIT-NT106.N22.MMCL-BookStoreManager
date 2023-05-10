using Client.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FMainCustomer : Form
    {
        public FMainCustomer()
        {
            InitializeComponent();
        }

        private void pnContentAdmin_Paint(object sender, PaintEventArgs e)
        {
            UCDashboardCustomer uCDashboardCustomer = new UCDashboardCustomer();
            addUserControl(uCDashboardCustomer);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnContentCustomer.Controls.Clear();
            pnContentCustomer.Controls.Add(userControl);
            userControl.BringToFront();
        }
    }
}
