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
    public partial class AssignSubject : Form
    {
        string bind;
        public AssignSubject(string username)
        {
            
            InitializeComponent();
            //populate combo box with classes
            bind = username;
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\Desktop\IOOP Group Assignment\ETCDatabase\ETCDatabase\ETCTutor.mdf;Integrated Security=True";
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                string sqlString = $@"select * from ClassInfo";
                using (var command = new SqlCommand(sqlString, conn))
                {
                    using (SqlDataReader oReader = command.ExecuteReader())
                    {
                        if (oReader.HasRows)
                        {
                            while (oReader.Read())
                            {
                                comboBox1.Items.Add(oReader["Subject Name"]);
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var subject = comboBox1.Text;
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\Desktop\IOOP Group Assignment\ETCDatabase\ETCDatabase\ETCTutor.mdf;Integrated Security=True";
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                string check_limit = $@"select * from classes where student = '{bind}'";
                var check = new SqlCommand(check_limit, conn);
                if(check.ExecuteNonQuery() > 3)
                {
                    MessageBox.Show("Student can only have 3 classes maximum");
                }
                else
                {
                    
                    string sqlString = $@"insert into classes(student,subject,paid) values('{bind}','{subject}','unpaid')";
                    var command = new SqlCommand(sqlString, conn);
                    if (command.ExecuteNonQuery() < 1)
                    {
                        MessageBox.Show("could not assign subject");
                    }
                    else
                    {
                        this.Close();
                    }
                }
                
            }
        }
    }
}
