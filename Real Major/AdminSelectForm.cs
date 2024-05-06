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
    public partial class AdminSelectForm : Form
    {
        UserClass user1;
        public AdminSelectForm(UserClass user)
        {
            user1 = user;
            InitializeComponent();
            PopulateCountriesComboBox();
            PopulateTownsComboBox();
            PopulateOffersComboBox();
            showButton.Enabled= false;  
            changeHouseInfoButton.Enabled= false;   
            changeInfoButton.Enabled= false;  
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
                using (SqlConnection connection = new SqlConnection(@"Data Source=OFFICE-30637054\SQLEXPRESS;Initial Catalog= House_Offers;Integrated Security=True"))
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
                using (SqlConnection connection = new SqlConnection(@"Data Source=OFFICE-30637054\SQLEXPRESS;Initial Catalog= House_Offers;Integrated Security=True"))
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
            ChangeHouse forma7 = new ChangeHouse(user1, Convert.ToString(houseComboBox.SelectedItem));
            forma7.Show();
            this.Hide();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            HousePage House = new HousePage(user1, Convert.ToString(houseComboBox.SelectedItem));
            House.Show();
            this.Hide();
        }

        private void changeInfoButton_Click(object sender, EventArgs e)
        {
            AdminChangeInformation Add_Delete = new AdminChangeInformation(user1);
            Add_Delete.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            LoginForm forma1 = new LoginForm();
            forma1.Show();
            this.Hide();
        }

        private void townComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void houseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showButton.Enabled = true;
            changeHouseInfoButton.Enabled = true;
            changeInfoButton.Enabled = true;
        }
    }
}
