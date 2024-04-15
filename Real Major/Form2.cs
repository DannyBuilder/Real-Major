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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string password1 = TextBox2.Text;
            string password2 = textBox3.Text;

            string Pattern = "^(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%_&?*])[A-Za-z0-9!@#$%_&?*]{8,}$";
            if (Regex.IsMatch(password1, Pattern) && password1.Equals(password2))
            {
                MessageBox.Show("Valid");
                string salt = "";
                string salt1;
                salt = DateTime.Now.ToString();
                salt1 = salt;
                string password = TextBox2.Text;
                string hashedpass = hashpassword($"{password}{salt}");
                MessageBox.Show(hashedpass);
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ETJDNTM;Initial Catalog= House_Offers;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO UserProfile (Username, pass, date_) VALUES (@username, @hashedpass, @salt)", con);
                cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
                cmd.Parameters.AddWithValue("@salt", salt);
                cmd.Parameters.AddWithValue("@hashedpass", hashedpass);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Added to the Database");



            }
            else
            {
                MessageBox.Show("Invalid");
            }


        }
        string hashpassword(string text)
        {
            SHA256 hashAlgorithm = SHA256.Create();
            var bytes = Encoding.Default.GetBytes(text);
            var hash = hashAlgorithm.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

    }
}

