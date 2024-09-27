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

namespace sadguru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-VMGILA06\\SQLEXPRESS02;Initial Catalog=dattguru;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into usertb values("+textBox1.Text+",'"+textBox2.Text+"',"+textBox3.Text+")",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("submit");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-VMGILA06\\SQLEXPRESS02;Initial Catalog=dattguru;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update usertb set name='"+textBox2.Text+"', age="+textBox3.Text+" where id="+textBox1.Text+"",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("update sucessfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-VMGILA06\\SQLEXPRESS02;Initial Catalog=dattguru;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("delete from usertb where id="+textBox1.Text+"",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Delete sucessfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-VMGILA06\\SQLEXPRESS02;Initial Catalog=dattguru;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from usertb",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;


        }
    }
}
