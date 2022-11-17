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
    public partial class frmProfile : Form
    {
        public static string name;
        public frmProfile()
        {
            InitializeComponent();
        }

        public frmProfile(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void lblProfile_Click(object sender, EventArgs e)
        {

        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            TutorProfile obj1 = new TutorProfile(name);

            txtBoxPassword.Text = obj1.Password;
            txtBoxPhoneNum.Text = obj1.PhoneNum;
            txtBoxEmail.Text = obj1.Email;
            txtBoxSubject.Text = obj1.Subject;
        }

        private void btnUdt_Click(object sender, EventArgs e)
        {
            TutorProfile obj1 = new TutorProfile(name);
            MessageBox.Show(obj1.updateTutorProfile(txtBoxPassword.Text, txtBoxPhoneNum.Text, txtBoxEmail.Text, txtBoxSubject.Text));
        }
    }
}
