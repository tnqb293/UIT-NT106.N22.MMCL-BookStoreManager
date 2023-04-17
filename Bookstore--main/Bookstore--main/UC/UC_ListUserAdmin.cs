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
    public partial class UC_ListUserAdmin : UserControl
    {
        public UC_ListUserAdmin()
        {
            InitializeComponent();
        }
        

        private void drvListUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UC_ListUser_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-OJKQD5I\SQLEXPRESS;Initial Catalog=DBBookstore;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "select * from Account";
            SqlCommand commnad = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(commnad);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataSet.Tables[0];
            drvListUser.DataSource = bindingSource;
            connection.Close();
        }
    }
}
