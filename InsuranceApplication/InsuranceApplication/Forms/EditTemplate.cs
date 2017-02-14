using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceApplication.Forms
{
    public partial class EditTemplate : Form
    {
        public EditTemplate()
        {
            InitializeComponent();
        }

        private void EditTemplate_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateFName_Click(object sender, EventArgs e)
        {
            btnUpdateFName.Visible = false;
            btnSaveFName.Visible = txtFName.Visible = true;
        }

        private void btnUpdateLName_Click(object sender, EventArgs e)
        {
            btnUpdateLName.Visible = false;
            btnSaveLName.Visible = txtLName.Visible = true;
        }

        private void btnSaveFName_Click(object sender, EventArgs e)
        {
            lblFName.Text = txtFName.Text;
            txtFName.Clear();
            btnSaveFName.Visible = txtFName.Visible = false;
            btnUpdateFName.Visible = true;
        }

        private void btnSaveLName_Click(object sender, EventArgs e)
        {
            lblLName.Text = txtLName.Text;
            txtLName.Clear();
            btnSaveLName.Visible = txtLName.Visible = false;
            btnUpdateLName.Visible = true;
        }
    }
}
