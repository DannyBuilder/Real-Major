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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Real_Major
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 register = new Form2();
            register.Show();
            this.Hide();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passBox.Text;
            string pass;
            string data;
            string connectionString = @"Data Source=DESKTOP-ETJDNTM;Initial Catalog= House_Offers;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
               try
               {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT pass, date_ from UserProfile where Username = @username", con);
                    cmd.Parameters.AddWithValue("@username", username);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataTable resultTable = new DataTable();
                    adapter.Fill(resultTable);
                    if (resultTable.Rows.Count > 0)
                    {
                        pass = (string)resultTable.Rows[0]["pass"];
                        data = (string)resultTable.Rows[0]["date_"];
                        string salt = "";
                        string salt1;
                        salt = DateTime.Now.ToString();
                        salt1 = salt;
                        string hashedpass = hashpassword($"{password}{data}");
                        if (username == "Daniel" && pass == hashedpass) {
                            DialogResult = DialogResult.OK;
                            Form3 admin = new Form3();
                            admin.Show();
                            this.Hide();

                        }
                        else if (pass == hashedpass)
                        {
                            Form4 user = new Form4();
                            user.Show();
                            this.Hide();

                        }
                        else {
                            MessageBox.Show("Incorrect password!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No such user!");

                    }
             }
               catch (Exception ex)
             {
                   MessageBox.Show("Error");

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
}