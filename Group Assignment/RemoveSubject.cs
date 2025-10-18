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
    public partial class RemoveSubject : Form
    {
        string bind;
        public RemoveSubject(string username)
        {
            bind = username;
            InitializeComponent();
            //populate combolist with subjects user is enrolled in
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\Desktop\IOOP Group Assignment\ETCDatabase\ETCDatabase\ETCTutor.mdf;Integrated Security=True";
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                string sqlString = $@"select * from classes where student = '{username}'";
                using (var command = new SqlCommand(sqlString, conn))
                {
                    using (SqlDataReader oReader = command.ExecuteReader())
                    {
                        if (oReader.HasRows)
                        {
                            while (oReader.Read())
                            {
                                comboBox1.Items.Add(oReader["subject"]);
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
                string sqlString = $@"delete from classes where student = '{bind}' and subject = '{subject}'";
                var command = new SqlCommand(sqlString, conn);
                if(command.ExecuteNonQuery() < 1)
                {
                    MessageBox.Show("could not remove subject");
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
