using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Stocks_Viewer
{
    public partial class admin_login_form : Form
    {
        public admin_login_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string SQLConnect = "data source = localhost; database=BevPizza; integrated security = true";
                SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
                SqlCommand SQLCommand = new SqlCommand("select * from admin_table where admin_key = @key and admin_username = @username and admin_password = @password;", SQLDatabase);
                SQLDatabase.Open();

                SQLCommand.Parameters.AddWithValue("@key", txtbx_key.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@username", txtbx_username.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@password", txtbx_password.Text).ToString();

                SqlDataReader SQLReader = SQLCommand.ExecuteReader();

                int count = 0;

                while (SQLReader.Read())
                {
                    count = count + 1;
                }

                if (count == 1)
                {
                    MessageBox.Show("Username and Password is CORRECT!");

                    Hide();

                    Admin adminform = new Admin();
                    adminform.Show();
                }

                else
                    MessageBox.Show("Username or Password is incorrect!");

                SQLDatabase.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void admin_login_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();

            Form1 mainform = new Form1();
            mainform.Show();
        }
    }
}
