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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

            dtbasetolbl();

            timer1.Start();

            dbasetodtgrid_order();
            dbasetodtgrid_archivestocks();
        }

        void dbasetodtgrid_order()
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
                dtgrid_orders.DataSource = SQLBindSource;
                SQLAdapter.Update(SQLTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dtgrid_orders.Columns[0].HeaderText = "Order Number";
            dtgrid_orders.Columns[1].HeaderText = "Sauce";
            dtgrid_orders.Columns[2].HeaderText = "Pepperoni";
            dtgrid_orders.Columns[3].HeaderText = "Bacon";
            dtgrid_orders.Columns[4].HeaderText = "Sausage";
            dtgrid_orders.Columns[5].HeaderText = "Ham";
            dtgrid_orders.Columns[6].HeaderText = "Parmesan Cheese";
            dtgrid_orders.Columns[7].HeaderText = "Cucumber";
            dtgrid_orders.Columns[8].HeaderText = "Salad Oil";
            dtgrid_orders.Columns[9].HeaderText = "Garlic Herb";
            dtgrid_orders.Columns[10].HeaderText = "Status";
            dtgrid_orders.Columns[11].HeaderText = "Size";
        }

        void dbasetodtgrid_archivestocks()
        {
            try
            {
                string SQLConnect = "data source = localhost; database = BevPizza; integrated security = true";
                string Query = "select Employee_Number, sauce, pepperoni, bacon, sausage, ham, parmesan_cheese, cucumber, salad_oil, garlic_herb, date_time from Old_Ingredients ;";
                SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
                SqlCommand SQLCommand = new SqlCommand(Query, SQLDatabase);
                //SQLDatabase.Open();

                SqlDataAdapter SQLAdapter = new SqlDataAdapter();
                SQLAdapter.SelectCommand = SQLCommand;
                DataTable SQLTable = new DataTable();
                SQLAdapter.Fill(SQLTable);
                BindingSource SQLBindSource = new BindingSource();

                SQLBindSource.DataSource = SQLTable;
                dtgrid_arhivestocks.DataSource = SQLBindSource;
                SQLAdapter.Update(SQLTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dtgrid_arhivestocks.Columns[0].HeaderText = "Employee Number";
            dtgrid_arhivestocks.Columns[1].HeaderText = "Sauce";
            dtgrid_arhivestocks.Columns[2].HeaderText = "Pepperoni";
            dtgrid_arhivestocks.Columns[3].HeaderText = "Bacon";
            dtgrid_arhivestocks.Columns[4].HeaderText = "Sausage";
            dtgrid_arhivestocks.Columns[5].HeaderText = "Ham";
            dtgrid_arhivestocks.Columns[6].HeaderText = "Parmesan Cheese";
            dtgrid_arhivestocks.Columns[7].HeaderText = "Cucumber";
            dtgrid_arhivestocks.Columns[8].HeaderText = "Salad Oil";
            dtgrid_arhivestocks.Columns[9].HeaderText = "Garlic Herb";
            dtgrid_arhivestocks.Columns[10].HeaderText = "Date & Time";
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

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime pcdatetime = DateTime.Now;
            lbl_timer.Text = pcdatetime.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();

            Form1 mainform = new Form1();
            mainform.Show();
        }

        private void radio_orders_CheckedChanged(object sender, EventArgs e)
        {
            dtgrid_orders.Visible = true;
            dtgrid_arhivestocks.Visible = false;
        }

        private void radio_stocks_CheckedChanged(object sender, EventArgs e)
        {
            dtgrid_orders.Visible = false;
            dtgrid_arhivestocks.Visible = true;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dtbasetolbl();

            dbasetodtgrid_order();
            dbasetodtgrid_archivestocks();
        }
    }
}
