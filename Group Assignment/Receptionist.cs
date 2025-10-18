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
        string username_to_change;


        public Receptionist()
        {
            InitializeComponent();
            SqlDataAdapter da;
            SqlDataAdapter data;
            SqlDataAdapter data1;
            string fileData = File.ReadAllText("user.dnk");
            username_to_change = fileData;
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
                string sql2 = $@"select * from Profile where username = '{fileData}'";
                using (var third_command = new SqlCommand(sql2, conn))
                {
                    //pre-fill data with data about the receptionist
                    using (SqlDataReader oReader = third_command.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            textBox2.Text = oReader["username"].ToString();
                            textBox3.Text = oReader["email"].ToString();
                            textBox4.Text = oReader["phonenumber"].ToString();
                        }
                    }


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

        private void button4_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\Desktop\IOOP Group Assignment\ETCDatabase\ETCDatabase\ETCTutor.mdf;Integrated Security=True";
            var conn = new SqlConnection(connString);
            conn.Open();
            //update data in profile
            var username = textBox2.Text;
            var email = textBox3.Text;
            var phone = textBox4.Text;
            var password = textBox5.Text;
            //check if username is taken
            var check_sql = $@"select * from Profile where username = '{username}'";
            var update_sql = $@"update Profile set email='{email}', phonenumber='{phone}', username = '{username}',password='{password}' where username='{username_to_change}'";
            using (var command = new SqlCommand(check_sql, conn))
            {
              
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Username already in use");
                        conn.Close();
                    }
                    reader.Close();
                    var update_command = new SqlCommand(update_sql, conn);

                    if(update_command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Profile updated");
                        File.WriteAllText("user.dnk", username);
                    }
                   
                }


            }
            
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //delete all entries from database that where status = completed
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\Desktop\IOOP Group Assignment\ETCDatabase\ETCDatabase\ETCTutor.mdf;Integrated Security=True";
            var conn = new SqlConnection(connString);
            conn.Open();
            var delete = $@"delete from requests where status = 'completed'";
            var delete_command = new SqlCommand(delete, conn);
            delete_command.ExecuteNonQuery();
            updateView();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //update status to completed for all entries
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\Desktop\IOOP Group Assignment\ETCDatabase\ETCDatabase\ETCTutor.mdf;Integrated Security=True";
            var conn = new SqlConnection(connString);
            conn.Open();
            var update = $@"update requests set status = 'completed'";
            var update_command = new SqlCommand(update, conn);
            update_command.ExecuteNonQuery();
            updateView();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //delete every entry
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\Desktop\IOOP Group Assignment\ETCDatabase\ETCDatabase\ETCTutor.mdf;Integrated Security=True";
            var conn = new SqlConnection(connString);
            conn.Open();
            var delete = $@"delete from requests";
            var delete_command = new SqlCommand(delete, conn);
            delete_command.ExecuteNonQuery();
            updateView();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //show dialogue;enter the id of entry to set status to completed
            var dialog = new StatusUpdate();
            dialog.ShowDialog();
        }
        private void updateView()
        {
            SqlDataAdapter da;
            SqlDataAdapter data;
            SqlDataAdapter data1;
            string fileData = File.ReadAllText("user.dnk");
            username_to_change = fileData;
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
                using (var second_command = new SqlCommand(sql, conn))
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
                string sql2 = $@"select * from Profile where username = '{fileData}'";
                using (var third_command = new SqlCommand(sql2, conn))
                {
                    //pre-fill data with data about the receptionist
                    using (SqlDataReader oReader = third_command.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            textBox2.Text = oReader["username"].ToString();
                            textBox3.Text = oReader["email"].ToString();
                            textBox4.Text = oReader["phonenumber"].ToString();
                        }
                    }


                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            updateView();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            updateView();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            updateView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var username = textBox1.Text;
            Payments payment = new Payments(username);
            payment.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //show student subjects and allow editing
            Enrollment subjectAllocation = new Enrollment();
            subjectAllocation.ShowDialog();
        }
    }
}
