using System;
using System.Collections;
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
    public partial class frmStudents : Form
    {
        public frmStudents()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\Desktop\IOOP Group Assignment\ETCDatabase\ETCDatabase\ETCTutor.mdf;Integrated Security=True";
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                string sqlString = @"select * from Students ";
                using (var command = new SqlCommand(sqlString, conn))
                {

                    da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    studentList.DataSource = dt;
                }
            }
        }
    }
}
