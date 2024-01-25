using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLMS1
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addbook f = new Addbook();
            f.Show();
            //f.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReturnBookReport M = new ReturnBookReport();
            M.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IssueBookReport L = new IssueBookReport();
            L.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewBook g = new ViewBook();
            g.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddStudent h = new AddStudent();
            h.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            viewStudents i = new viewStudents();
            i.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IssueBook j = new IssueBook();
            j.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            returnBook k = new returnBook();
            k.Show();
        }
    }
}
