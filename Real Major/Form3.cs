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
    public partial class Form3 : Form
    {
        UserClass user1;
        public Form3(UserClass user)
        {
            user1 = user;
            InitializeComponent();
            PopulateCountriesComboBox();
            PopulateTownsComboBox();
            PopulateOffersComboBox();
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
                            countryComboBox.Items.Add(reader["CountryName"].ToString());
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
                            townComboBox.Items.Add(reader["Town_Name"].ToString());
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
                            houseComboBox.Items.Add(reader["House"].ToString());
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



        private void HouseInformation_Click(object sender, EventArgs e)
        {
            Form7 forma7 = new Form7(user1, Convert.ToString(houseComboBox.SelectedItem));
            forma7.Show();
            this.Hide();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Form6 House = new Form6(user1, Convert.ToString(houseComboBox.SelectedItem));
            House.Show();
            this.Hide();
        }

        private void changeInfoButton_Click(object sender, EventArgs e)
        {
            Form5 Add_Delete = new Form5(user1);
            Add_Delete.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 forma1 = new Form1();
            forma1.Show();
            this.Hide();
        }
    }
}
