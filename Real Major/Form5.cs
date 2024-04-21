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
        public Form5()
        {
            InitializeComponent();
            countryButton.Checked = true;
            label.Text = "Country";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 forma3 = new Form3();
            forma3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-ETJDNTM;Initial Catalog= House_Offers;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand();

            if (townButton.Checked)
            {
                cmd = new SqlCommand("INSERT INTO Towns (Town) VALUES(@Town)", con);
                cmd.Parameters.AddWithValue("@Town", countryBox.Text);
            }
            else if (countryButton.Checked)
            {
                cmd = new SqlCommand("INSERT INTO Countries (CountryName) VALUES(@Country)", con);
                cmd.Parameters.AddWithValue("@Town", countryBox.Text);
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
                cmd = new SqlCommand("Delte from Towns Where Town = @Town", con);
                cmd.Parameters.AddWithValue("@Town", countryBox.Text);
            }
            else if (countryButton.Checked)
            {
                cmd = new SqlCommand("Delete from Countries CountryName = @Country", con);
                cmd.Parameters.AddWithValue("@Town", countryBox.Text);
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
            // nz kak da raboti tochno updatea
        }
    }
}

