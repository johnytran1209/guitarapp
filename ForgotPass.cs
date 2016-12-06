using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginApp
{
    public partial class ForgotPass : Form
    {
        public ForgotPass()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ad\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From LOGIN where USERNAME='" + textBox2.Text + "'and EMAIL='" + textBox3.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                con.Open();
                MessageBox.Show("Usernam and e-mail confirmed");
                SqlDataAdapter x = new SqlDataAdapter("Select QUESTION from LOGIN where USERNAME='" + textBox2.Text + "'and EMAIL='" + textBox3.Text + "'", con);
                DataTable y = new DataTable();
                x.Fill(y);
                label5.Visible = true;
                label5.Text = y.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("Username or e-mail incorrect");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ad\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter a = new SqlDataAdapter("Select COUNT(*) From LOGIN where QUESTION='" + label5.Text + "'and ANSWER='" + textBox1.Text + "'", con);
            DataTable b = new DataTable();
            a.Fill(b);
            if (b.Rows[0][0].ToString()== "1")
            {
                string sql = "UPDATE LOGIN SET PASSWORD='"+label5.Text+"' where USERNAME='" + textBox2.Text + "'";
                SqlDataAdapter data = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                data.Fill(ds, "LOGIN");
                MessageBox.Show("Your Password have been reset to 'NAMELESS'");
                this.Close();
                Form1 x = new Form1();
                x.Show();
            }
            else
            {
                MessageBox.Show("Your answer was incorrect");
            }
        }
    }
}
