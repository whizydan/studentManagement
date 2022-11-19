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
    public partial class StatusUpdate : Form
    {
        public StatusUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = textBox1.Text;
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\Desktop\IOOP Group Assignment\ETCDatabase\ETCDatabase\ETCTutor.mdf;Integrated Security=True";
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                string sqlString = $@"update requests set status = 'completed' where id = '{id}'";
                var command = new SqlCommand(sqlString, conn);
                if(command.ExecuteNonQuery() > 0){
                    this.Close();
                }
                else
                {
                    MessageBox.Show("could not update try again later");
                }
            }
        }
    }
}
