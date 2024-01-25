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
    public partial class AddStudent : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-4R8FA7GU;Initial Catalog=library;Integrated Security=true");

        public AddStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_students", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Student_Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Enrollment_No", textBox2.Text);
            cmd.Parameters.AddWithValue("@Department", textBox3.Text);
            cmd.Parameters.AddWithValue("@contact", textBox4.Text);
            cmd.Parameters.AddWithValue("@email", textBox5.Text);
            cmd.Parameters.AddWithValue("@semester", textBox6.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Student details Added Successfully");
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }
    }
}
