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

        //UPDATE
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
        private void btnUpdateUsername_Click(object sender, EventArgs e)
        {
            btnUpdateUsername.Visible = false;
            btnSaveUsername.Visible = txtUsername.Visible = true;
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            btnUpdatePassword.Visible = false;
            btnSavePassword.Visible = txtPassword.Visible = true;
        }

        private void btnUpdateEmail_Click(object sender, EventArgs e)
        {
            btnUpdateEmail.Visible = false;
            btnSaveEmail.Visible = txtEmail.Visible = true;
        }

        private void btnUpdateAddress_Click(object sender, EventArgs e)
        {
            btnUpdateAddress.Visible = false;
            btnSaveAddress.Visible = txtAddress.Visible = true;
        }

        //SAVE

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

        private void btnSaveUsername_Click(object sender, EventArgs e)
        {
            lblUsername.Text = txtUsername.Text;
            txtUsername.Clear();
            btnSaveUsername.Visible = txtUsername.Visible = false;
            btnUpdateUsername.Visible = true;
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            lblPassword.Text = txtPassword.Text;
            txtPassword.Clear();
            btnSavePassword.Visible = txtPassword.Visible = false;
            btnUpdatePassword.Visible = true;
        }

        private void btnSaveEmail_Click(object sender, EventArgs e)
        {
            lblEmail.Text = txtEmail.Text;
            txtEmail.Clear();
            btnSaveEmail.Visible = txtEmail.Visible = false;
            btnUpdateEmail.Visible = true;
        }

        private void btnSaveAddress_Click(object sender, EventArgs e)
        {
            lblAddress.Text = txtAddress.Text;
            txtAddress.Clear();
            btnSaveAddress.Visible = txtAddress.Visible = false;
            btnUpdateAddress.Visible = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            Forms.AdminHome f3 = new Forms.AdminHome();
            f3.Show();
        }
    }
}
