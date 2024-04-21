using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Major
{
    public partial class Form6 : Form
    {
        bool ab;
        public Form6(bool a)
        {
            ab = a;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ab)
            {
                Form3 forma3 = new Form3();
                forma3.Show();
                this.Hide();
            }
            else
            {
                Form4 forma4 = new Form4();
                forma4.Show();
                this.Hide();
            }

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
