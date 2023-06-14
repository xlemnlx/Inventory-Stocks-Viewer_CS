using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stocks_Viewer
{
    public partial class new_employee : Form
    {
        public new_employee()
        {
            InitializeComponent();
        }
        
        void generatenewidnumber()
        {
            try
            {
                /*
                 * this part is for determining the last id number in the database and will increment for the new employee....
                 */
                string SQLConnect = "data source = localhost; database = BevPizza; integrated security = true;";
                string Query = "Select Employee_Number from Employee;";
                SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
                SqlCommand SQLCommand = new SqlCommand(Query, SQLDatabase);

                SQLDatabase.Open();

                SqlDataReader SQLReader = SQLCommand.ExecuteReader();

                while (SQLReader.Read())
                {
                    lbl_oldidnumber.Text = SQLReader.GetValue(0).ToString();
                }

                SQLDatabase.Close();

                lbl_oldidnumber.Text = (int.Parse(lbl_oldidnumber.Text) + 1).ToString();

                lbl_newidnumber.Text = lbl_oldidnumber.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void new_employee_Load(object sender, EventArgs e)
        {
            generatenewidnumber();
        }

        private void bttn_Signup_Click(object sender, EventArgs e)
        {
            savenewemployee();

            MessageBox.Show("SAVED");

            generatenewidnumber();

            txtbx_firstname.Text = null;
            txtbx_lastname.Text = null;
            txtbx_username.Text = null;
            txtbx_password.Text = null;
        }

        void savenewemployee()
        {
            string SQLConnect = "data source = localhost; database = BevPizza; integrated security = true;";
            string Query = "Insert into Employee (Employee_Number, FName, LName, username, password) values (@number, @fname, @lname, @username, @password);";
            SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
            SqlCommand SQLCommand = new SqlCommand(Query, SQLDatabase);
            SQLDatabase.Open();
            try
            {
                SQLCommand.Parameters.AddWithValue("@number", lbl_newidnumber.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@fname", txtbx_firstname.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@lname", txtbx_lastname.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@username", txtbx_username.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@password", txtbx_password.Text).ToString();

                SQLCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SQLDatabase.Close();
        }
    }
}
