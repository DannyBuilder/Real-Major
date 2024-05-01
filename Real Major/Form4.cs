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
    public partial class Form4 : Form
    {
        UserClass user1;
        public Form4(UserClass user)
        {
            user1 = user;
            InitializeComponent();
            PopulateCountriesComboBox();
            PopulateOffersComboBox();
            PopulateTownsComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 House = new Form6(user1, Convert.ToString(comboBox3.SelectedItem));
            House.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 forma1 = new Form1();
            forma1.Show();
            this.Hide();
        }
        private void PopulateCountriesComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-ETJDNTM;Initial Catalog= House_Offers;Integrated Security=True"))
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
        private void PopulateTownsComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-ETJDNTM;Initial Catalog= House_Offers;Integrated Security=True"))
                {
                    string query = "SELECT Town_Name FROM Towns";
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
        private void PopulateOffersComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-ETJDNTM;Initial Catalog= House_Offers;Integrated Security=True"))
                {
                    string query = "SELECT House FROM Offers";
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

    }
}
