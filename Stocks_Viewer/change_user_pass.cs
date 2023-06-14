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
    public partial class change_user_pass : Form
    {
        public change_user_pass()
        {
            InitializeComponent();

            dtbasetocmbobox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string SQLConnect = "data source = localhost; database = BevPizza; integrated security = true";
                string Query = "Update Employee set username = @username, password = @password where Employee_Number = @employeenumber";
                SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
                SqlCommand SQLCommand = new SqlCommand(Query, SQLDatabase);
                SQLDatabase.Open();

                SQLCommand.Parameters.AddWithValue("@employeenumber", cmbobx_name.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@username", txtbx_username.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@password", txtbx_password.Text).ToString();

                MessageBox.Show("Saved!");

                SqlDataReader SQLReader = SQLCommand.ExecuteReader();

                SQLDatabase.Close();

                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void dtbasetocmbobox()
        {
            try
            {
                string SQLConnect = "data source = localhost; database=BevPizza; integrated security = true";
                SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
                SqlCommand SQLCommand = new SqlCommand("select * from Employee", SQLDatabase);
                SQLDatabase.Open();

                SqlDataReader SQLReader = SQLCommand.ExecuteReader();

                while (SQLReader.Read())
                {
                    string dtbasevalues = SQLReader.GetValue(0).ToString();
                    cmbobx_name.Items.Add(dtbasevalues);
                }

                SQLDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
