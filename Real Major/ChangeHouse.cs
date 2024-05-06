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
    public partial class ChangeHouse : Form
    {
        UserClass user1;
        string house1;
        public ChangeHouse(UserClass user, string house)
        {
            user1 = user;
            house1 = house;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images Files(.jpg; *jpeg; *.png; *.gif; *.bmp) |.jpg; jpeg; *.png; *.gif; *.bmp| All files(.)|.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string picturePath = openFileDialog.FileName;
                    Image selectedPicture = Image.FromFile(picturePath);
                    byte[] pictureData = ImageToByteArray(selectedPicture);
                    SqlConnection con = new SqlConnection(@"Data Source=OFFICE-30637054\SQLEXPRESS;Initial Catalog= House_Offers;Integrated Security=True");
                    con.Open();
                    if (colorTextBox.Text == "" && adressTextBox.Text == "" && priceTextBox.Text == "" && descriptionTextBox.Text == "")
                    {
                        SqlCommand cmd = new SqlCommand("Update Offers set photo = @picture where House = @house", con);
                        cmd.Parameters.AddWithValue("@house", house1);
                        cmd.Parameters.AddWithValue("@picture", pictureData);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        pictureBox1.Image = selectedPicture;
                        MessageBox.Show("Picture  was inserted");
                    }
                    else
                    {


                        SqlCommand cmd = new SqlCommand("Update Offers set photo = @picture, Color = @Color, Adress=@Adress, Price = @Price, Description_ = @Description where House = @house", con);
                        //SqlCommand cmd = new SqlCommand("INSERT INTO User_Profiles (picture, firstName, lastName, country, gender) VALUES(@picture, @firstname, @lastname, @country, @gender ) WHERE username = @username", con);

                        cmd.Parameters.AddWithValue("@house", house1);
                        cmd.Parameters.AddWithValue("@picture", pictureData);
                        cmd.Parameters.AddWithValue("@Color", colorTextBox.Text);
                        cmd.Parameters.AddWithValue("@Adress", adressTextBox.Text);
                        cmd.Parameters.AddWithValue("@Price", priceTextBox.Text);
                        cmd.Parameters.AddWithValue("@Description", descriptionTextBox.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        pictureBox1.Image = selectedPicture;
                        MessageBox.Show("Data  was inserted");
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

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminSelectForm forma3 = new AdminSelectForm(user1);
            forma3.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
