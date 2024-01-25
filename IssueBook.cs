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
    public partial class IssueBook : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-4R8FA7GU;Initial Catalog=library;Integrated Security=true");

        public IssueBook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_ViewStudents", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Enrollment_No", textBox4.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
                //textBox4.Text = dr[].ToString();
                textBox5.Text = dr[4].ToString();
                textBox6.Text = dr[3].ToString();
            }
            dr.Close();
            con.Close();
        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_getBook", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_AddIssueBook", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StudentName", textBox1.Text);
            cmd.Parameters.AddWithValue("@Enrollment_No", textBox2.Text);
            cmd.Parameters.AddWithValue("@Department", textBox3.Text);
            cmd.Parameters.AddWithValue("@Contact", textBox6.Text);
            cmd.Parameters.AddWithValue("@Email", textBox5.Text);
            cmd.Parameters.AddWithValue("@BookName", comboBox1.Text);
            cmd.Parameters.AddWithValue("@IssueDate", dateTime1.Value);
            cmd.Parameters.AddWithValue("@ReturnDate", "");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Issue Book Added Successfully");
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.Text = "";
        }
    }
}
