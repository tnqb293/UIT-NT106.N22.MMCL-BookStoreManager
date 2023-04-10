using BookstoreOnline.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreOnline
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (taskBarProgress.Value == 100)
            {
                timer1.Stop();
                Form f = new User();
                f.Show();
                this.Hide();
            }
            else
                taskBarProgress.Value+=2;
        }
        

        private void SplashScreenForm_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
