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

namespace Group_Assignment
{
    public partial class Enrollment : Form
    {
        public Enrollment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AssignSubject assign = new AssignSubject(textBox1.Text);
            assign.ShowDialog();
        }
        private void UpdateView(string username)
        {
            SqlDataAdapter da;
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\Desktop\IOOP Group Assignment\ETCDatabase\ETCDatabase\ETCTutor.mdf;Integrated Security=True";
            using (var conn = new SqlConnection(connString))
            { 
                conn.Open();
                string sqlString = $@"select * from classes where student = '{username}' ";
                using (var command = new SqlCommand(sqlString, conn))
                {
                    //grid classes for individual students
                    da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateView(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveSubject removal = new RemoveSubject(textBox1.Text);
            removal.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            UpdateView(textBox1.Text);
        }
    }
}
