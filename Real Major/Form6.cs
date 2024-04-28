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
    public partial class Form6 : Form
    {
        UserClass user1;
        string house1;
        public Form6(UserClass user, string house)
        {
            user1 = user;
            house1 = house;

            InitializeComponent();
            
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ETJDNTM;Initial Catalog= House_Offers;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Color, Adress, Price, Description_, Town FROM Offers WHERE House = @house", con);
            cmd.Parameters.AddWithValue("@house", house1);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (!(house1 == ""))
            {
                Description.Text = table.Rows[0]["Description_"].ToString();
                Adress.Text = table.Rows[0]["Adress"].ToString();
                Color.Text = table.Rows[0]["Color"].ToString();
                Price.Text = table.Rows[0]["Price"].ToString();
                House.Text = house1;
                con.Close();
            }
            else {
                Description.Text = "No House Selected";
                Adress.Text = "No House Selected";
                Color.Text = "No House Selected";
                Price.Text = "No House Selected";
                House.Text = "No House Selected";
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user1.roleID == 2)
            {
                Form3 forma3 = new Form3(user1);
                forma3.Show();
                this.Hide();
            }
            else
            {
                Form4 forma4 = new Form4(user1);
                forma4.Show();
                this.Hide();
            }

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
