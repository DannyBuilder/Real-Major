using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Real_Major
{
    public partial class GridView : Form
    {
        UserClass user1;
        private string connectionString = @"Data Source=DESKTOP-UUN906P;Initial Catalog=House_Offers;Integrated Security=True";
        private DataTable resultTable;
        private int count;
        public GridView(UserClass user)
        {
            user1 = user;
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT o.House, o.Color, o.Adress, o.Price, t.Town_Name AS Town, o.photo FROM Offers o INNER JOIN Towns t ON o.Town = t.TownsID", con);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    resultTable = new DataTable();
                    adapter.Fill(resultTable);
                    dataGridView.RowTemplate.Height = 200;
                    dataGridView.DataSource = resultTable;

                    DataGridViewImageColumn pic = (DataGridViewImageColumn)dataGridView.Columns[5];
                    pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL error occured. Please try again. {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unknown error occured. Please try again. {ex.Message}");
                }
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UUN906P;Initial Catalog=House_Offers;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT o.House, o.Color, o.Adress, o.Price, t.Town_Name AS Town, o.photo FROM Offers o INNER JOIN Towns t ON o.Town = t.TownsID WHERE o.House = @house", con);
                cmd.Parameters.AddWithValue("@house", searchBox.Text);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                resultTable = new DataTable();
                adapter.Fill(resultTable);
                dataGridView.RowTemplate.Height = 200;
                dataGridView.DataSource = resultTable;
                DataGridViewImageColumn pic = (DataGridViewImageColumn)dataGridView.Columns[5];
                pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
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

        private void filterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterBox2.Items.Clear();
            filterBox2.SelectedItem = null;
            populateFilterBox2(filterBox.SelectedItem.ToString());
        }
        private void populateFilterBox2(string s)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-UUN906P;Initial Catalog=House_Offers;Integrated Security=True"))
                {
                    if (s == "Color")
                    {
                        string query = $"SELECT DISTINCT COLOR FROM Offers";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                filterBox2.Items.Add(reader["Color"].ToString());
                            }
                            reader.Close();
                        }
                    }
                    else if (s == "Town")
                    {
                        string query = $"SELECT DISTINCT Town_Name FROM Towns";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                filterBox2.Items.Add(reader["Town_Name"].ToString());
                            }
                            reader.Close();
                        }
                    }
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

        private void refreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UUN906P;Initial Catalog=House_Offers;Integrated Security=True");
                con.Open();
                if (filterBox.SelectedItem.ToString() == "Color")
                {
                    SqlCommand cmd = new SqlCommand("SELECT o.House, o.Color, o.Adress, o.Price, t.Town_Name AS Town, o.photo FROM Offers o INNER JOIN Towns t ON o.Town = t.TownsID WHERE o.Color = @color", con);
                    cmd.Parameters.AddWithValue("@color", filterBox2.SelectedItem.ToString());
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    resultTable = new DataTable();
                    adapter.Fill(resultTable);
                }
                else if (filterBox.SelectedItem.ToString() == "Town")
                {
                    SqlCommand cmd = new SqlCommand("SELECT o.House, o.Color, o.Adress, o.Price, t.Town_Name AS Town, o.photo FROM Offers o INNER JOIN Towns t ON o.Town = t.TownsID WHERE t.Town_Name = @town", con);
                    cmd.Parameters.AddWithValue("@town", filterBox2.SelectedItem.ToString());
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    resultTable = new DataTable();
                    adapter.Fill(resultTable);
                }
                dataGridView.RowTemplate.Height = 200;
                dataGridView.DataSource = resultTable;
                DataGridViewImageColumn pic = (DataGridViewImageColumn)dataGridView.Columns[5];
                pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
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

        private void backButton_Click(object sender, EventArgs e)
        {
            SelectForm form = new SelectForm(user1);
            form.Show();
            this.Hide();
        }
    }
}
