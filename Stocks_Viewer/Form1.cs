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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void dbasetodtgrid()
        {
            try
            {
                string SQLConnect = "data source = localhost; database = BevPizza; integrated security = true";
                string Query = "select order_number, sauce, pepperoni, bacon, sausage, ham, parmesan_cheese, cucumber, salad_oil, garlic_herb, status, size from order_archive ;";
                SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
                SqlCommand SQLCommand = new SqlCommand(Query, SQLDatabase);
                //SQLDatabase.Open();

                SqlDataAdapter SQLAdapter = new SqlDataAdapter();
                SQLAdapter.SelectCommand = SQLCommand;
                DataTable SQLTable = new DataTable();
                SQLAdapter.Fill(SQLTable);
                BindingSource SQLBindSource = new BindingSource();

                SQLBindSource.DataSource = SQLTable;
                dataGridView1.DataSource = SQLBindSource;
                SQLAdapter.Update(SQLTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.Columns[0].HeaderText = "Order Number";
            dataGridView1.Columns[1].HeaderText = "Sauce";
            dataGridView1.Columns[2].HeaderText = "Pepperoni";
            dataGridView1.Columns[3].HeaderText = "Bacon";
            dataGridView1.Columns[4].HeaderText = "Sausage";
            dataGridView1.Columns[5].HeaderText = "Ham";
            dataGridView1.Columns[6].HeaderText = "Parmesan Cheese";
            dataGridView1.Columns[7].HeaderText = "Cucumber";
            dataGridView1.Columns[8].HeaderText = "Salad Oil";
            dataGridView1.Columns[9].HeaderText = "Garlic Herb";
            dataGridView1.Columns[10].HeaderText = "Status";
            dataGridView1.Columns[11].HeaderText = "Size";
        }

        void dtbasetolbl()
        {
            string SQLConnect = "data source = localhost; database = BevPizza; integrated security = true";
            SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
            SQLDatabase.Open();
            SqlCommand SQLCommand = new SqlCommand("select * from Ingredients ;", SQLDatabase);
            SqlDataReader SQLReader = SQLCommand.ExecuteReader();
            try
            {
                while (SQLReader.Read())
                {
                    //lbl_flour.Text = SQLReader.GetValue(0).ToString();
                    lbl_sauce.Text = SQLReader.GetValue(1).ToString();
                    lbl_pepperoni.Text = SQLReader.GetValue(2).ToString();
                    lbl_bacon.Text = SQLReader.GetValue(3).ToString();
                    lbl_sausage.Text = SQLReader.GetValue(4).ToString();
                    lbl_ham.Text = SQLReader.GetValue(5).ToString();
                    lbl_parmesancheese.Text = SQLReader.GetValue(6).ToString();
                    lbl_cucumber.Text = SQLReader.GetValue(7).ToString();
                    lbl_saladoil.Text = SQLReader.GetValue(8).ToString();
                    lbl_garlicherb.Text = SQLReader.GetValue(9).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SQLDatabase.Close();
        }

        private void LogIn_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string SQLConnect = "data source = localhost; database=BevPizza; integrated security = true";
                SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
                SqlCommand SQLCommand = new SqlCommand("select * from Employee where username = @username and password = @password;", SQLDatabase);
                SQLDatabase.Open();

                SQLCommand.Parameters.AddWithValue("@username", textBox1.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@password", textBox2.Text).ToString();

                SqlDataReader SQLReader = SQLCommand.ExecuteReader();

                int count = 0;

                while (SQLReader.Read())
                {
                    count = count + 1;
                }

                if (count == 1)
                {
                    MessageBox.Show("Username and Password is CORRECT!");
                    LogIn_GrpBox.Hide();
                    LogIn_Admin_GroupBox.Hide();
                    groupBox2.Hide();
                    grpbx_inventory.Visible = true;
                    menuStrip1.Visible = true;
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dtbasetolbl();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are Your Sure You Want to Log-Out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                grpbx_inventory.Hide();
                groupBox2.Show();
                LogIn_GrpBox.Show();
                textBox1.Text = null;
                textBox2.Text = null;
                menuStrip1.Visible = false;
            }
            else if (DialogResult == DialogResult.No)
            {
                grpbx_inventory.Show();
            }
        }

        private void loginAsADMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();

            admin_login_form adminloginform = new admin_login_form();
            adminloginform.Show();
        }

        private void addStocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Stocks AddStocks = new Add_Stocks();
            AddStocks.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void changeUsernamePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_user_pass changeuserpassform = new change_user_pass();
            changeuserpassform.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime pcdatetime = DateTime.Now;
            lbl_timer.Text = pcdatetime.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtbasetolbl();

            timer1.Start();

            dbasetodtgrid();
        }

        private void LogIn_Button_Admin_Click(object sender, EventArgs e)
        {
            try
            {
                string SQLConnect = "data source = localhost; database=BevPizza; integrated security = true";
                SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
                SqlCommand SQLCommand = new SqlCommand("select * from admin_table where admin_key = @key and admin_username = @username and admin_password = @password;", SQLDatabase);
                SQLDatabase.Open();

                SQLCommand.Parameters.AddWithValue("@key", textBox3.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@username", textBox4.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@password", textBox5.Text).ToString();

                SqlDataReader SQLReader = SQLCommand.ExecuteReader();

                int count = 0;

                while (SQLReader.Read())
                {
                    count = count + 1;
                }

                if (count == 1)
                {
                    MessageBox.Show("Username and Password is CORRECT!");
                    this.Hide();
                    Admin admin_form = new Admin();
                    admin_form.Show();
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

        private void RDBttn_Employee_CheckedChanged(object sender, EventArgs e)
        {
            LogIn_GrpBox.Visible = true;
            LogIn_Admin_GroupBox.Visible = false;
        }

        private void RDBttn_Admin_CheckedChanged(object sender, EventArgs e)
        {
            LogIn_GrpBox.Visible = false;
            LogIn_Admin_GroupBox.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new_employee signup = new new_employee();
            signup.Show();
        }
    }
}
