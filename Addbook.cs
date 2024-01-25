using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLMS1
{
    public partial class Addbook : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-4R8FA7GU;Initial Catalog=library;Integrated Security=true");

        public Addbook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_Add_Books", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BookName", textBox1.Text);
            cmd.Parameters.AddWithValue("@AuthorName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Publication", textBox3.Text);
            cmd.Parameters.AddWithValue("@PurchaseDate", dateTime1.Value); 
            cmd.Parameters.AddWithValue("@BookPrice", textBox5.Text);
            cmd.Parameters.AddWithValue("@Quantity", textBox6.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Book Added Successfully");
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
