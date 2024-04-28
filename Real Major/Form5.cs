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
    public partial class Form5 : Form
    {
        UserClass user1;
        public Form5(UserClass user)
        {
            user1 = user;
            InitializeComponent();
            countryButton.Checked = true;
            label.Text = "Country";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 forma3 = new Form3(user1);
            forma3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-ETJDNTM;Initial Catalog= House_Offers;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand();

            if (townButton.Checked)
            {
                cmd = new SqlCommand("Delete from Towns Where Town_Name = @Town", con);
                cmd.Parameters.AddWithValue("@Town", countryBox.Text);
            }
            else if (countryButton.Checked)
            {
                cmd = new SqlCommand("Delete from Countries Where CountryName = @Country", con);
                cmd.Parameters.AddWithValue("@Country", countryBox.Text);
            }
            else
            {
                cmd = new SqlCommand("Delete from Offers Where House = @House", con);
                cmd.Parameters.AddWithValue("@House", countryBox.Text);
            }

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was deleted");
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
                if (!string.IsNullOrWhiteSpace(countryBox.Text) && !string.IsNullOrWhiteSpace(newCountryBox.Text))
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ETJDNTM;Initial Catalog= House_Offers;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE Towns SET Town_Name = @city WHERE Town_Name = @replacedCity", con))
                        {
                            cmd.Parameters.AddWithValue("@city", newCountryBox.Text);
                            cmd.Parameters.AddWithValue("@replacedCity", countryBox.Text);
                            con.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            con.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Town updated successfully");
                                countryBox.Clear();
                                newCountryBox.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Town not found for replacement");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid town names");
                }
            }
            else if (countryButton.Checked)
            {
                if (!string.IsNullOrWhiteSpace(countryBox.Text) && !string.IsNullOrWhiteSpace(newCountryBox.Text))
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ETJDNTM;Initial Catalog= House_Offers;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE Countries SET CountryName = @city WHERE CountryName = @replacedCity", con))
                        {
                            cmd.Parameters.AddWithValue("@city", newCountryBox.Text);
                            cmd.Parameters.AddWithValue("@replacedCity", countryBox.Text);
                            con.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            con.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Country updated successfully");
                                countryBox.Clear();
                                newCountryBox.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Country not found for replacement");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid country names");
                }
            }
            else {
                if (!string.IsNullOrWhiteSpace(countryBox.Text) && !string.IsNullOrWhiteSpace(newCountryBox.Text))
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ETJDNTM;Initial Catalog= House_Offers;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE Offers SET House = @city WHERE House = @replacedCity", con))
                        {
                            cmd.Parameters.AddWithValue("@city", newCountryBox.Text);
                            cmd.Parameters.AddWithValue("@replacedCity", countryBox.Text);
                            con.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            con.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("House offer updated successfully");
                                countryBox.Clear();
                                newCountryBox.Clear();
                            }
                            else
                            {
                                MessageBox.Show("House offer not found for replacement");
                            }
                        }
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
            string connectionString = @"Data Source=DESKTOP-ETJDNTM;Initial Catalog= House_Offers;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand();

            if (townButton.Checked)
            {
                cmd = new SqlCommand("INSERT INTO Towns (Town_Name) VALUES(@Town)", con);
                cmd.Parameters.AddWithValue("@Town", countryBox.Text);
            }
            else if (countryButton.Checked)
            {
                cmd = new SqlCommand("INSERT INTO Countries (CountryName) VALUES(@Country)", con);
                cmd.Parameters.AddWithValue("@Country", countryBox.Text);
            }
            else
            {
                cmd = new SqlCommand("INSERT INTO Offers (House) VALUES(@House)", con);
                cmd.Parameters.AddWithValue("@House", countryBox.Text);
            }

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was added");
        }


    }
}

