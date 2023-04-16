using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore__main.UC
{
    public partial class UC_ListUser : UserControl
    {
        public UC_ListUser()
        {
            InitializeComponent();
        }

        private void UC_ListUser_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-67KGLN6P\SQLEXPRESS;Initial Catalog=BookStoreManager;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "select * from Account";
            SqlCommand commnad = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(commnad);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataSet.Tables[0];
            dgvListUser.DataSource = bindingSource;
            connection.Close();
        }
    }
}
