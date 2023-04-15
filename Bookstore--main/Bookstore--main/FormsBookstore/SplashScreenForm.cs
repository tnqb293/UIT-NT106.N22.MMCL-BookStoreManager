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
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
     
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            timer.Start();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (taskbarProgress.Value == 100)
            {
                timer.Stop();
                Form f = new AdminForm();
                f.Show();
                this.Close();
            }
            else
                taskbarProgress.Value += 5;
        }
    }
}
