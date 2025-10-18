using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Assignment
{
  
    public partial class Login : Form
    {

        SqlDataAdapter da;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get vaues from interface
            var userName = username.Text;
            var passWord = password.Text;
            
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\Desktop\IOOP Group Assignment\ETCDatabase\ETCDatabase\ETCTutor.mdf;Integrated Security=True";
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                string sqlString = $@"select * from Profile where username = '{userName}' and password = '{passWord}'";
                using (var command = new SqlCommand(sqlString, conn))
                {
                    using (SqlDataReader oReader = command.ExecuteReader())
                    {
                        //check if a user exists with provided credentials
                        if (oReader.HasRows)
                        {
                            while (oReader.Read())
                            {
                               
                                var role = oReader["role"].ToString();
                                var username = oReader["username"].ToString();
                                File.WriteAllText("user.dnk", username);
                                switch (role)
                                {
                                    //redirect to the appropriate user roles
                                    case "admin":
                                        Admin page = new Admin();
                                        Hide();
                                        page.Show();
                                        break;
                                    case "tutor":
                                        frmTutor page1 = new frmTutor();
                                        Hide();
                                        page1.Show();
                                        break;
                                    case "receptionist":
                                        Receptionist page2 = new Receptionist();
                                        Hide();
                                        page2.Show();
                                        break;
                                    case "student":
                                        StudentPage page3 = new StudentPage();
                                        Hide();
                                        page3.Show();
                                        break;
                                }
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Try again");
                        }

                    }

                }
            }
        }
    }
}
