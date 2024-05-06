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
    public partial class HousePage : Form
    {
        UserClass user1;
        string house1;
        public HousePage(UserClass user, string house)
        {
            user1 = user;
            house1 = house;

            InitializeComponent();

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=OFFICE-30637054\SQLEXPRESS;Initial Catalog= House_Offers;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Color, Adress, Price, Description_, Town, photo FROM Offers WHERE House = @house", con);
                cmd.Parameters.AddWithValue("@house", house1);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable table = new DataTable();
                adapter.Fill(table);



                if ((house1 == ""))
                {
                    Description.Text = "No House Selected";
                    Adress.Text = "No House Selected";
                    Color.Text = "No House Selected";
                    Price.Text = "No House Selected";
                    House.Text = "No House Selected";
                    con.Close();
                }
                else if (!(DBNull.Value.Equals(table.Rows[0]["photo"])))
                {
                    Description.Text = table.Rows[0]["Description_"].ToString();
                    Adress.Text = table.Rows[0]["Adress"].ToString();
                    Color.Text = table.Rows[0]["Color"].ToString();
                    Price.Text = table.Rows[0]["Price"].ToString();
                    House.Text = house1;
                    HousePicture.Image = ByteArrayToImage((byte[])table.Rows[0]["photo"]);
                    con.Close();
                }
                else
                {
                    Description.Text = table.Rows[0]["Description_"].ToString();
                    Adress.Text = table.Rows[0]["Adress"].ToString();
                    Color.Text = table.Rows[0]["Color"].ToString();
                    Price.Text = table.Rows[0]["Price"].ToString();
                    House.Text = house1;
                    con.Close();

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (user1.roleID == 2)
            {
                AdminSelectForm forma3 = new AdminSelectForm(user1);
                forma3.Show();
                this.Hide();
            }
            else
            {
                SelectForm forma4 = new SelectForm(user1);
                forma4.Show();
                this.Hide();
            }

        }
        private byte[] ImageToByteArray(Image picture)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                picture.Save(ms, picture.RawFormat);
                return ms.ToArray();
            }
        }
        private Image ByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        
        private void ShowHouse_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; 

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (HousePicture.Left <= 490)
            {
                HousePicture.Left = HousePicture.Left + 10;
            }
        }

        private void Color_Click(object sender, EventArgs e)
        {

        }

        private void Adress_Click(object sender, EventArgs e)
        {

        }
    }
}
