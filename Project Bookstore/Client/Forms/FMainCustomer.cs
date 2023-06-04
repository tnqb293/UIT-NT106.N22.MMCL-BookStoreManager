using Client.Class;
using Client.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Client.Forms
{
    public partial class FMainCustomer : Form
    {
        private IpConnection ipConnection = new IpConnection();
        public Thread receiveThread { get; set; }
        private static InfoUser info = new InfoUser();
        //--------
        public static FMainCustomer instance;
        public Label lbtext;
        //--------
        public FMainCustomer(string user)
        {
            InitializeComponent();
            instance = this;
            lbtext = lbMoney;
            info.username = user;
           
        }
        private void pnContentAdmin_Paint(object sender, PaintEventArgs e)
        {
            UCDashboardCustomer uCDashboardCustomer = new UCDashboardCustomer(info.username);
            addUserControl(uCDashboardCustomer);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnContentCustomer.Controls.Clear();
            pnContentCustomer.Controls.Add(userControl);
            userControl.BringToFront();
        }
     
        private void FMainCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                string message = "request|moneyCustomer " + info.username;
                StringBuilder builder = ipConnection.ConnectToServer(message);
                lbNameCustomer.Text = info.username;
                lbMoney.Text = builder.ToString();
            }
            catch
            {
                this.Invoke(new Action(() => MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)));

            }
        
        }
        private void pnControlCustomer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnListBookPanel_Click(object sender, EventArgs e)
        {
            UCListBookCustomer uc = new UCListBookCustomer(info.username);
            addUserControl(uc);
        }

        private void btnDashboardPanel_Click(object sender, EventArgs e)
        {
            UCDashboardCustomer uc = new UCDashboardCustomer(info.username);
            addUserControl(uc);
            
        }

        private void btnPurchaseBookPanel_Click(object sender, EventArgs e)
        {
            
            UCListPurchaseBookCustomer uc = new UCListPurchaseBookCustomer(info.username);
            addUserControl(uc);
        }

        private void btnPurchaseHistory_Click(object sender, EventArgs e)
        {
            UCListPurchaseHistoryCustomer uc = new UCListPurchaseHistoryCustomer(info.username);
            addUserControl(uc);
        }

        private void btnSettingAccountPanel_Click(object sender, EventArgs e)
        {
            UCSettingAccountCustomer uc = new UCSettingAccountCustomer(info.username);
            addUserControl(uc);
        }
    }
}
