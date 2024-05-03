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
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Real_Major
{

    public partial class Form1 : Form
    {
        public static UserClass user = new UserClass();
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
                        errorProvider1.SetError(usernameBox, string.Empty);
                        pass = (string)resultTable.Rows[0]["pass"];
                        data = (string)resultTable.Rows[0]["date_"];
                        string salt = "";
                        string salt1;
                        salt = DateTime.Now.ToString();
                        salt1 = salt;
                        string hashedpass = hashpassword($"{password}{data}");
                        if (pass == hashedpass)
                        {
                            errorProvider2.SetError(passBox, string.Empty);

                            fillUserInfo(connectionString, username, user);
                            MessageBox.Show(Convert.ToString(user.roleID));
                            if (user.roleID == 1)
                            {
                                Form4 userForm = new Form4(user);
                                userForm.Show();
                                this.Hide();
                            }
                            else if (user.roleID == 2)
                            {
                                Form3 adminForm = new Form3(user);
                                adminForm.Show();
                                this.Hide();
                            }

                        }
                        else
                        {
                            errorProvider2.SetError(passBox, "Incorrect password");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(usernameBox, "No such user");

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
            string hashpassword(string text)
            {
                SHA256 hashAlgorithm = SHA256.Create();
                var bytes = Encoding.Default.GetBytes(text);
                var hash = hashAlgorithm.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fillUserInfo(string connectionString, string username, UserClass user)
        {
            int role;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT role_ from UserProfile where Username = @username", con);
                    cmd.Parameters.AddWithValue("@username", username);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataTable resultTable = new DataTable();
                    adapter.Fill(resultTable);

                    if (resultTable.Rows.Count > 0)
                    {
                        //    int id = int.Parse((string)resultTable.Rows[0]["id"]);
                        role = (int)resultTable.Rows[0]["role_"];

                        user.fillUserinfo(2, username, role);
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
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
