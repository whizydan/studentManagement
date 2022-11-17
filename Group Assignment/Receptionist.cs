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
    public partial class Receptionist : Form
    {
       
        public Receptionist()
        {
            InitializeComponent();
            SqlDataAdapter da;
            SqlDataAdapter data;
            SqlDataAdapter data1;
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\Desktop\IOOP Group Assignment\ETCDatabase\ETCDatabase\ETCTutor.mdf;Integrated Security=True";
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                string sqlString = @"select * from Students ";
                using (var command = new SqlCommand(sqlString, conn))
                {
                    //grid data for all students
                    da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    studentsList2.DataSource = dt;
                }
                string sql = @"select * from transactions";
                using(var second_command = new SqlCommand(sql, conn))
                {
                    //grid data for all transactions
                    data = new SqlDataAdapter(second_command);
                    DataTable transaction = new DataTable();
                    data.Fill(transaction);
                    transactions.DataSource = transaction;
                }
                string sql1 = @"select * from requests";
                using (var second_command = new SqlCommand(sql1, conn))
                {
                    //grid data for all requests
                    data1 = new SqlDataAdapter(second_command);
                    DataTable requests = new DataTable();
                    data1.Fill(requests);
                    requestList.DataSource = requests;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudent student = new AddStudent();
            student.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteStudent deleteStudent = new DeleteStudent();
            deleteStudent.ShowDialog();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
