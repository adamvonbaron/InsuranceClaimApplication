using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InsuranceApplication.Classes;

namespace InsuranceApplication
{
    public partial class formInsuranceClaim : Form
    {
        public formInsuranceClaim()
        {
            InitializeComponent();
        }

        //private libsql objCheck;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //String UN = SQLDriver.GetUser(txtUsername.ToString());
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            //get password
            password = txtPassword.Text;
            //link login to admin home page
            if (password == "admin")
            {
                Forms.AdminHome f1 = new Forms.AdminHome();
                f1.Show();
            }

            //link login to client home page
            else if (password == "client")
            {
                Forms.ClientHome f2 = new Forms.ClientHome();
                f2.Show();
            }
            
            //link login to client manager home page
            else if (password == "claimmanager")
            {
                Forms.ClaimManager f3 = new Forms.ClaimManager();
                f3.Show();
            }

            //link login to finance manager home page
            else if (password == "financemanager")
            {
                Forms.FinanceManagerHome f4 = new Forms.FinanceManagerHome();
                f4.Show();
            }

            else
            {
                  MessageBox.Show("Warning", "Please enter a valid password!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Forms.Register f4 = new Forms.Register();
            f4.Show();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            Forms.ForgotPassword f3 = new Forms.ForgotPassword();
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            formFormDemo ffd = new formFormDemo();
            ffd.Show();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Forms.UserEditProfile uep = new Forms.UserEditProfile();
            uep.Show();
        }
    }
}
