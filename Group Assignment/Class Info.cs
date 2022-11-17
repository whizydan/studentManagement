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
    public partial class frmClassInfo : Form
    {
        public frmClassInfo()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddClassInfo frmAddClassInfo = new frmAddClassInfo();
            frmAddClassInfo.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateClassInfo frmUpdateClassInfo = new frmUpdateClassInfo();
            frmUpdateClassInfo.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDeleteClassInfo frmDeleteClassInfo = new frmDeleteClassInfo();
            frmDeleteClassInfo.ShowDialog();
        }

        private void lblClass_Click(object sender, EventArgs e)
        {

        }

        private void frmClassInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
