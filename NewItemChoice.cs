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
    public partial class NewItemChoice : Form
    {
        public NewItemChoice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            NewItem x = new NewItem();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            NewItem x = new NewItem();
            x.Show();
        }
    }
}
