using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Major
{
    public partial class SelectForm : Form
    {
        UserClass user1;

        public SelectForm(UserClass user)
        {

            user1 = user;

            InitializeComponent();
            PopulateCountriesComboBox();
            button1.Enabled = false;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            HousePage House = new HousePage(user1, Convert.ToString(comboBox3.SelectedItem));
            House.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm forma1 = new LoginForm();
            forma1.Show();
            this.Hide();
        }
        private void PopulateCountriesComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=OFFICE-30637054\SQLEXPRESS;Initial Catalog= House_Offers;Integrated Security=True"))
                {
                    string query = "SELECT CountryName FROM Countries";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["CountryName"].ToString());
                        }
                        reader.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("There was an error with the SQL Server! Please try again!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error! Please try again!");
            }
        }
        private void PopulateTownsComboBox(int a)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=OFFICE-30637054\SQLEXPRESS;Initial Catalog= House_Offers;Integrated Security=True"))
                {
                    string query = $"SELECT  Town_Name FROM Towns where CountryID= {a} ";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            comboBox2.Items.Add(reader["Town_Name"].ToString());
                        }
                        reader.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("There was an error with the SQL Server! Please try again!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error! Please try again!");
            }
        }
        private void PopulateOffersComboBox(int a)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=OFFICE-30637054\SQLEXPRESS;Initial Catalog= House_Offers;Integrated Security=True"))
                {
                    string query = $"SELECT House FROM Offers Where Town={a}";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            comboBox3.Items.Add(reader["House"].ToString());
                        }
                        reader.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("There was an error with the SQL Server! Please try again!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error! Please try again!");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.SelectedText = string.Empty;
            if (comboBox1.SelectedIndex == 0)
            {
                PopulateTownsComboBox(1);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                PopulateTownsComboBox(2);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                PopulateTownsComboBox(3);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();

            if (comboBox2.SelectedItem.ToString() == "Sofia")
            {
                PopulateOffersComboBox(1);
            }
            else if (comboBox2.SelectedItem.ToString() == "Berlin")
            {
                PopulateOffersComboBox(2);
            }
            else if (comboBox2.SelectedItem.ToString() == "Rome")
            {
                PopulateOffersComboBox(3);
            }
            else if (comboBox2.SelectedItem.ToString() == "Munich")
            {
                PopulateOffersComboBox(4);
            }
            else if (comboBox2.SelectedItem.ToString() == "Bansko")
            {
                PopulateOffersComboBox(5);
            }
            else if (comboBox2.SelectedItem.ToString() == "Milan")
            {
                PopulateOffersComboBox(6);
            }

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }
    }
}
