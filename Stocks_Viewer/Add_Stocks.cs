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
    public partial class Add_Stocks : Form
    {
        public Add_Stocks()
        {
            InitializeComponent();

            dbasetolabel();

            timer1.Start();

            dtbasetocmbobox();
        }

        void dbasetolabel()
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

        private void button_add_Click(object sender, EventArgs e)
        {
            
            try
            {
                string SQLConnect = "data source = localhost; database=BevPizza; integrated security = true";
                SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
                SqlCommand SQLCommand = new SqlCommand("select * from Employee where Employee_Number = @employeenumber and username = @username and password = @password;", SQLDatabase);
                SQLDatabase.Open();

                SQLCommand.Parameters.AddWithValue("@employeenumber", comboBox1.Text).ToString();
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
                    sumsauce();
                    sumpepperoni();
                    sumbacon();
                    sumsausage();
                    sumham();
                    sumparmesancheese();
                    sumcucumber();
                    sumsaladoil();
                    sumgarlicherb();

                    updatedbase();

                    inserttoarchivedbase();

                    if (MessageBox.Show("SAVED!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        this.Hide();
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

        void sumsauce()
        {
            try
            {
                int base_sauce;
                int txt_sauce;

                int.TryParse(lbl_sauce.Text, out base_sauce);
                int.TryParse(txtbx_sauce.Text, out txt_sauce);

                new_sauce.Text = (base_sauce + txt_sauce).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void sumpepperoni()
        {
            try
            {
                int base_pepperoni;
                int txt_pepperoni;

                int.TryParse(lbl_pepperoni.Text, out base_pepperoni);
                int.TryParse(txtbx_pepperoni.Text, out txt_pepperoni);

                new_pepperoni.Text = (base_pepperoni + txt_pepperoni).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void sumbacon()
        {
            try
            {
                int base_bacon;
                int txt_bacon;

                int.TryParse(lbl_bacon.Text, out base_bacon);
                int.TryParse(txtbx_bacon.Text, out txt_bacon);

                new_bacon.Text = (base_bacon + txt_bacon).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void sumsausage()
        {
            try
            {
                int base_sausage;
                int txt_sausage;

                int.TryParse(lbl_sausage.Text, out base_sausage);
                int.TryParse(txtbx_sausage.Text, out txt_sausage);

                new_sausage.Text = (base_sausage + txt_sausage).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void sumham()
        {
            try
            {
                int base_ham;
                int txt_ham;

                int.TryParse(lbl_ham.Text, out base_ham);
                int.TryParse(txtbox_ham.Text, out txt_ham);

                new_ham.Text = (base_ham + txt_ham).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void sumparmesancheese()
        {
            try
            {
                int base_parmesancheese;
                int txt_parmesancheese;

                int.TryParse(lbl_parmesancheese.Text, out base_parmesancheese);
                int.TryParse(txtbx_parmesancheese.Text, out txt_parmesancheese);

                new_parmesancheese.Text = (base_parmesancheese + txt_parmesancheese).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void sumcucumber()
        {
            try
            {
                int base_cucumber;
                int txt_cucumber;

                int.TryParse(lbl_cucumber.Text, out base_cucumber);
                int.TryParse(txtbx_cucumber.Text, out txt_cucumber);

                new_cucumber.Text = (base_cucumber + txt_cucumber).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void sumsaladoil()
        {
            try
            {
                int base_saladoil;
                int txt_saladoil;

                int.TryParse(lbl_saladoil.Text, out base_saladoil);
                int.TryParse(txtbx_saladoil.Text, out txt_saladoil);

                new_saladoil.Text = (base_saladoil + txt_saladoil).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void sumgarlicherb()
        {
            try
            {
                int base_garlicherb;
                int txt_garlicherb;

                int.TryParse(lbl_garlicherb.Text, out base_garlicherb);
                int.TryParse(txtbx_garlicherb.Text, out txt_garlicherb);

                new_garlicherb.Text = (base_garlicherb + txt_garlicherb).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void updatedbase()
        {
            try
            {
                string SQLConnect = "data source = localhost; database = BevPizza; integrated security = true";
                string Query = "Update Ingredients set sauce=@sauce, pepperoni=@pepperoni, bacon=@bacon, sausage=@sausage, ham=@ham, parmesan_cheese=@parmesancheese, cucumber=@cucumber, salad_oil=@saladoil, garlic_herb=@garlicherb where sauce='" + lbl_sauce.Text + "' and pepperoni='" + lbl_pepperoni.Text + "' and bacon='" + lbl_bacon.Text + "' and sausage='" + lbl_sausage.Text + "' and ham='" + lbl_ham.Text + "' and parmesan_cheese='" + lbl_parmesancheese.Text + "' and cucumber='" + lbl_cucumber.Text + "' and salad_oil='" + lbl_saladoil.Text + "' and garlic_herb='" + lbl_garlicherb.Text + "'";
                SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
                SqlCommand SQLCommand = new SqlCommand(Query, SQLDatabase);
                SQLDatabase.Open();

                SQLCommand.Parameters.AddWithValue("@sauce", new_sauce.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@pepperoni", new_pepperoni.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@bacon", new_bacon.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@sausage", new_sausage.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@ham", new_ham.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@parmesancheese", new_parmesancheese.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@cucumber", new_cucumber.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@saladoil", new_saladoil.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@garlicherb", new_garlicherb.Text).ToString();

                SqlDataReader SQLReader = SQLCommand.ExecuteReader();

                SQLDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void inserttoarchivedbase()
        {
            try
            {
                string SQLConnect = "data source = localhost; database = BevPizza; integrated security = true";
                string Query = "Insert into Old_Ingredients (Employee_Number, sauce, pepperoni, bacon, sausage, ham, parmesan_cheese, cucumber, salad_oil, garlic_herb, date_time) values (@employeenumber, @sauce, @pepperoni, @bacon, @sausage, @ham, @parmesancheese, @cucumber, @saladoil, @garlicherb, @datetime)";
                SqlConnection SQLDatabase = new SqlConnection(SQLConnect);
                SqlCommand SQLCommand = new SqlCommand(Query, SQLDatabase);
                SQLDatabase.Open();

                SQLCommand.Parameters.AddWithValue("@employeenumber", comboBox1.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@sauce", lbl_sauce.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@pepperoni", lbl_pepperoni.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@bacon", lbl_bacon.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@sausage", lbl_sausage.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@ham", lbl_ham.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@parmesancheese", lbl_parmesancheese.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@cucumber", lbl_cucumber.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@saladoil", lbl_saladoil.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@garlicherb", lbl_garlicherb.Text).ToString();
                SQLCommand.Parameters.AddWithValue("@datetime", lbl_datetime.Text).ToString();

                SQLCommand.ExecuteNonQuery();

                SQLDatabase.Close();
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
                    comboBox1.Items.Add(dtbasevalues);
                }

                SQLDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime pcdatetime = DateTime.Now;
            lbl_datetime.Text = pcdatetime.ToString();
        }

        private void txtbx_sauce_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
    }
}
