using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            SaleRecord ss=new SaleRecord();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewItemChoice x = new NewItemChoice();
            x.Show();
        }
    }
}
