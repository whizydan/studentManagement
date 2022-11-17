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
    public partial class frmAddClassInfo : Form
    {
        public frmAddClassInfo()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClassInformation obj1 = new ClassInformation(txtBoxAdd.Text, txtBoxAdd1.Text, txtBoxAdd2.Text);
            MessageBox.Show(obj1.addClassInfo());
        }
    }
}
