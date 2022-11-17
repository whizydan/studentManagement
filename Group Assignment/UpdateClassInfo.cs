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
    public partial class frmUpdateClassInfo : Form
    {
        public static string name;
        public frmUpdateClassInfo()
        {
            InitializeComponent();
        }

        public frmUpdateClassInfo(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void frmUpdateClassInfo_Load(object sender, EventArgs e)
        {
            ClassInformation obj1 = new ClassInformation(name);

            txtBoxUdt1.Text = obj1.Charges;
            txtBoxUdt2.Text = obj1.Classschedule;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ClassInformation obj1 = new ClassInformation(name);
            MessageBox.Show(obj1.updateClassInfo(txtBoxUdt1.Text, txtBoxUdt2.Text));
        }
    }
}
