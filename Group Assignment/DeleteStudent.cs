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
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            /*
             To delete a student remove record from profile,classes,requests,students;
             To add new student add data to the above tables
             To process payment list students then unpaid for subjects
             To mark one complete enter id from grid view then update 
             To edit enrollment : enter id of student
             */
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\Desktop\IOOP Group Assignment\ETCDatabase\ETCDatabase\ETCTutor.mdf;Integrated Security=True";
            using (var conn = new SqlConnection(connString))
            {
                var username = textBox1.Text;
                conn.Open();
                string sql_classes = $@"delete from classes where student = '{username}'";
                string sql_profile = $@"delete from Profile where username = '{username}'";
                string sql_requests = $@"delete from requests where username = '{username}'";
                string sql_students = $@"delete from Students where username = '{username}'";
                var classes_command = new SqlCommand(sql_classes, conn);
                var profile_profile = new SqlCommand(sql_profile, conn);
                var classes_requests = new SqlCommand(sql_requests, conn);
                var classes_students= new SqlCommand(sql_students, conn);

                classes_command.ExecuteNonQuery();
                profile_profile.ExecuteNonQuery();
                classes_requests.ExecuteNonQuery();
                classes_students.ExecuteNonQuery();

                this.Close();

            }
        }
    }
}
