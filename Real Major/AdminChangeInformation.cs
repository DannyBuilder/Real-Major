using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Real_Major
{
    public partial class AdminChangeInformation : Form
    {
        UserClass user1;
        public AdminChangeInformation(UserClass user)
        {
            user1 = user;
            InitializeComponent();
            countryButton.Checked = true;
            label.Text = "Country";



        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-UUN906P;Initial Catalog=House_Offers;Integrated Security=True";
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand();

                if (townButton.Checked)
                {
                    cmd = new SqlCommand("Delete from Towns Where Town_Name = @Town", con);
                    cmd.Parameters.AddWithValue("@Town", currentNameBox.Text);
                }
                else if (countryButton.Checked)
                {
                    cmd = new SqlCommand("Delete from Countries Where CountryName = @Country", con);
                    cmd.Parameters.AddWithValue("@Country", currentNameBox.Text);
                }
                else
                {
                    cmd = new SqlCommand("Delete from Offers Where House = @House", con);
                    cmd.Parameters.AddWithValue("@House", currentNameBox.Text);
                }

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record was deleted");
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void townButton_CheckedChanged(object sender, EventArgs e)
        {
            if (townButton.Checked)
            {
                label.Text = "Town";
            }
        }

        private void countryButton_CheckedChanged(object sender, EventArgs e)
        {
            if (countryButton.Checked)
            {
                label.Text = "Country";
            }
        }

        private void houseButton_CheckedChanged(object sender, EventArgs e)
        {
            if (houseButton.Checked)
            {
                label.Text = "House";
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (townButton.Checked)
            {
                if (!string.IsNullOrWhiteSpace(currentNameBox.Text) && !string.IsNullOrWhiteSpace(updateBox.Text))
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(@"Data Source=OFFICE-30637054\SQLEXPRESS;Initial Catalog= House_Offers;Integrated Security=True"))
                        {
                            using (SqlCommand cmd = new SqlCommand("UPDATE Towns SET Town_Name = @city WHERE Town_Name = @replacedCity", con))
                            {
                                cmd.Parameters.AddWithValue("@city", updateBox.Text);
                                cmd.Parameters.AddWithValue("@replacedCity", currentNameBox.Text);
                                con.Open();
                                int rowsAffected = cmd.ExecuteNonQuery();
                                con.Close();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Town updated successfully");
                                    currentNameBox.Clear();
                                    updateBox.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("Town not found for replacement");
                                }
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
                else
                {
                    MessageBox.Show("Please enter valid town names");
                }
            }
            else if (countryButton.Checked)
            {
                if (!string.IsNullOrWhiteSpace(currentNameBox.Text) && !string.IsNullOrWhiteSpace(updateBox.Text))
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(@"Data Source=OFFICE-30637054\SQLEXPRESS;Initial Catalog= House_Offers;Integrated Security=True"))
                        {
                            using (SqlCommand cmd = new SqlCommand("UPDATE Countries SET CountryName = @city WHERE CountryName = @replacedCity", con))
                            {
                                cmd.Parameters.AddWithValue("@city", updateBox.Text);
                                cmd.Parameters.AddWithValue("@replacedCity", currentNameBox.Text);
                                con.Open();
                                int rowsAffected = cmd.ExecuteNonQuery();
                                con.Close();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Country updated successfully");
                                    currentNameBox.Clear();
                                    updateBox.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("Country not found for replacement");
                                }
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
                else
                {
                    MessageBox.Show("Please enter valid country names");
                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(currentNameBox.Text) && !string.IsNullOrWhiteSpace(updateBox.Text))
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(@"Data Source=OFFICE-30637054\SQLEXPRESS;Initial Catalog= House_Offers;Integrated Security=True"))
                        {
                            using (SqlCommand cmd = new SqlCommand("UPDATE Offers SET House = @city WHERE House = @replacedCity", con))
                            {
                                cmd.Parameters.AddWithValue("@city", updateBox.Text);
                                cmd.Parameters.AddWithValue("@replacedCity", currentNameBox.Text);
                                con.Open();
                                int rowsAffected = cmd.ExecuteNonQuery();
                                con.Close();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("House offer updated successfully");
                                    currentNameBox.Clear();
                                    updateBox.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("House offer not found for replacement");
                                }
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
                else
                {
                    MessageBox.Show("Please enter valid names");
                }

            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-UUN906P;Initial Catalog=House_Offers;Integrated Security=True";
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand();

                if (townButton.Checked)
                {
                    cmd = new SqlCommand("INSERT INTO Towns (Town_Name) VALUES(@Town)", con);
                    cmd.Parameters.AddWithValue("@Town", currentNameBox.Text);
                }
                else if (countryButton.Checked)
                {
                    cmd = new SqlCommand("INSERT INTO Countries (CountryName) VALUES(@Country)", con);
                    cmd.Parameters.AddWithValue("@Country", currentNameBox.Text);
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO Offers (House) VALUES(@House)", con);
                    cmd.Parameters.AddWithValue("@House", currentNameBox.Text);
                }

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record was added");
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

        private void Form5_Load_1(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminSelectForm forma3 = new AdminSelectForm(user1);
            forma3.Show();
            this.Hide();
        }

        private void logoLabel_Click(object sender, EventArgs e)
        {

        }

        private void backgroundPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}

