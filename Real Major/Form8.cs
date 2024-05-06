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

namespace Real_Major
{
    public partial class Form8 : Form
    {
        private string connectionString = @"Data Source=OFFICE-30637054\SQLEXPRESS;Initial Catalog= House_Offers;Integrated Security=True";
        private DataTable resultTable;
        private int count;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from UserProfile", con);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    resultTable = new DataTable();
                    adapter.Fill(resultTable);
                    dataGridView.RowTemplate.Height = 300;
                    dataGridView.Width = 1000;
                    dataGridView.DataSource = resultTable;

                    DataGridViewImageColumn pic = (DataGridViewImageColumn)dataGridView.Columns[1];
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
    }
}
