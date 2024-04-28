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
            errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            errorProvider3.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string password1 = TextBox2.Text;
            string password2 = textBox3.Text;

            string Pattern = "^(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%_&?*])[A-Za-z0-9!@#$%_&?*]{8,}$";

            if (string.IsNullOrEmpty(usernameTextBox.Text))
            {
                errorProvider1.SetError(usernameTextBox, "Invalid username");
            }
            else
            {

                errorProvider1.SetError(usernameTextBox, string.Empty);
            }
            if (string.IsNullOrEmpty(TextBox2.Text))
            {

                errorProvider2.SetError(TextBox2, "Invalid Password");
            }
            else
            {
                errorProvider2.SetError(TextBox2, string.Empty);

            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {

                errorProvider3.SetError(textBox3, "Invalid Password");
            }
            else
            {
                errorProvider3.SetError(textBox3, string.Empty);

            }


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
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ETJDNTM;Initial Catalog=House_Offers;Integrated Security=True");
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
                errorProvider1.SetError(usernameTextBox, "Invalid username");
                errorProvider2.SetError(TextBox2, "Invalid Password");
                errorProvider3.SetError(textBox3, "Invalid Password");
            }
        }

        string hashpassword(string text)
        {
            SHA256 hashAlgorithm = SHA256.Create();
            var bytes = Encoding.Default.GetBytes(text);
            var hash = hashAlgorithm.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 forma1 = new Form1();
            forma1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            string password1 = TextBox2.Text;
            string password2 = textBox3.Text;

            string Pattern = "^(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%_&?*])[A-Za-z0-9!@#$%_&?*]{8,}$";

            if (string.IsNullOrEmpty(usernameTextBox.Text))
            {
                errorProvider1.SetError(usernameTextBox, "Invalid username");
            }
            else
            {

                errorProvider1.SetError(usernameTextBox, string.Empty);
            }
            if (string.IsNullOrEmpty(TextBox2.Text))
            {

                errorProvider2.SetError(TextBox2, "Invalid Password");
            }
            else
            {
                errorProvider2.SetError(TextBox2, string.Empty);

            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {

                errorProvider3.SetError(textBox3, "Invalid Password");
            }
            else
            {
                errorProvider3.SetError(textBox3, string.Empty);

            }


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
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ETJDNTM;Initial Catalog=House_Offers;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO UserProfile (Username, pass, date_, role_) VALUES (@username, @hashedpass, @salt, @role)", con);
                cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
                cmd.Parameters.AddWithValue("@salt", salt);
                cmd.Parameters.AddWithValue("@hashedpass", hashedpass);
                cmd.Parameters.AddWithValue("@role", 1);
                cmd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Added to the Database");



            }
            else
            {
                errorProvider1.SetError(usernameTextBox, "Invalid username");
                errorProvider2.SetError(TextBox2, "Invalid Password");
                errorProvider3.SetError(textBox3, "Invalid Password");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 forma1 = new Form1();
            forma1.Show();
            this.Hide();
        }
    }
}

