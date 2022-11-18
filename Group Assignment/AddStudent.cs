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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\Desktop\IOOP Group Assignment\ETCDatabase\ETCDatabase\ETCTutor.mdf;Integrated Security=True";
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                string classes_sql = @"insert into classes(student,subject,paid) values ('kerberos','english',0)";
                string student_sql = $@"insert into 
                                        Students(ICPassport,Name,Email,PhoneNum,Address,Level,Month,username)
                                        values ('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}','{comboBox1.SelectedItem}','{comboBox3.SelectedItem}','{textBox6.Text}')";
                //add student to students table and to profile table
                string profile_sql = $@"insert into Profile(username,password,phonenumber,email,role)
                                        values('{textBox6.Text}','student','{textBox4.Text}','{textBox3.Text}','student')";

                
                var student_command = new SqlCommand(student_sql, conn);
                var profile_command = new SqlCommand(profile_sql, conn);

                profile_command.ExecuteNonQuery();
                student_command.ExecuteNonQuery();
                this.Close();
            }
        }
    }
}
