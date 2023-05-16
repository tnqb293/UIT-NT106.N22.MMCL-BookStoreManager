using Client.Class;
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
    public partial class FMainAdmin : Form
    {
        InfoUser infoUser = new InfoUser();
        public FMainAdmin(string user)
        {
            InitializeComponent();
            infoUser.username = user;
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnAdminContent.Controls.Clear();
            pnAdminContent.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnAddBookPanel_Click(object sender, EventArgs e)
        {
            UCAddBookAdmin uc = new UCAddBookAdmin(infoUser.username);
            addUserControl(uc);
        }

        private void btnListBookPanel_Click(object sender, EventArgs e)
        {
            UCListBookAdmin uc = new UCListBookAdmin(infoUser.username);
            addUserControl(uc);
        }
    }
}
