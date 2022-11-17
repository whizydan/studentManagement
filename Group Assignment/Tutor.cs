using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Assignment
{
    public partial class frmTutor : Form
    {
        public frmTutor()
        {
            InitializeComponent();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            frmClassInfo f2 = new frmClassInfo();
            f2.Show();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            frmStudents f3 = new frmStudents();
            f3.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmProfile f4 = new frmProfile();
            f4.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you and have a nice day!");
        }

        private void frmTutor_Load(object sender, EventArgs e)
        {

        }
    }
}
