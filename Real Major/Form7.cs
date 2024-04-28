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
    public partial class Form7 : Form
    {
        UserClass user1;
        string house1;
        public Form7(UserClass user, string house)
        {
            user1 = user;
            house1 = house;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 forma3 = new Form3(user1);
            forma3.Show();
            this.Hide();
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
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ETJDNTM;Initial Catalog= House_Offers;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Offers set photo = @picture, Color = @Color, Adress=@Adress, Price = @Price, Description_ = @Description where House = @house", con);
                    //SqlCommand cmd = new SqlCommand("INSERT INTO User_Profiles (picture, firstName, lastName, country, gender) VALUES(@picture, @firstname, @lastname, @country, @gender ) WHERE username = @username", con);
                    cmd.Parameters.AddWithValue("@house", house1);
                    cmd.Parameters.AddWithValue("@picture", pictureData);
                    cmd.Parameters.AddWithValue("@Color", ColorTextBox.Text);
                    cmd.Parameters.AddWithValue("@Adress", AdressTextBox.Text);
                    cmd.Parameters.AddWithValue("@Price", PriceTextBox.Text);
                    cmd.Parameters.AddWithValue("@Description", DescriptionTextBox.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    pictureBox1.Image = selectedPicture;
                    MessageBox.Show("Data  was inserted");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error:{ex.Message}");
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
    }
}
