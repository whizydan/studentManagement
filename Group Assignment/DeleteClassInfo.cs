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
    public partial class frmDeleteClassInfo : Form
    {
        public static string name;
        public frmDeleteClassInfo()
        {
            InitializeComponent();
        }

        public frmDeleteClassInfo(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void frmDeleteClassInfo_Load(object sender, EventArgs e)
        {
            ClassInformation obj1 = new ClassInformation(name);

            txtBoxDel1.Text = obj1.Charges;
            txtBoxDel2.Text = obj1.Classschedule;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ClassInformation obj1 = new ClassInformation(name);
            MessageBox.Show(obj1.deleteClassInfo(txtBoxDel1.Text, txtBoxDel2.Text));
        }
    }
}
