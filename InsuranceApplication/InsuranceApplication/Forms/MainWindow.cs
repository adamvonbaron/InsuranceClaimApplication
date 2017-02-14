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
using InsuranceApplication.Forms;

namespace InsuranceApplication
{
    public partial class formInsuranceClaim : Form
    {
        public formInsuranceClaim()
        {
            InitializeComponent();
        }

        libsql database = new libsql();

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

        private void btnLogin_Click(object sender, EventArgs e) {
            int rank;
            if(database.ValidateUser(txtUsername.Text, txtPassword.Text)) {
                rank = database.GetRank(txtUsername.Text);
                Form homescreen = null;
                switch(rank) {
                    case 1:
                        homescreen = new AdminHome();
                        break;
                    case 2:
                    case 3:
                        homescreen = new FinanceManagerHome();
                        break;
                   case 4:
                        homescreen = new ClientHome(database.GetFirstName(txtUsername.Text),
                                                    txtUsername.Text);
                        
                        break;
                }
                homescreen.Show();
            } else {
                MessageBox.Show("Wrong Username or Password.", "Error", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = String.Empty;
                txtPassword.Text = String.Empty;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register f4 = new Register();
            f4.Show();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPassword f3 = new ForgotPassword();
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
            EditTemplate et = new EditTemplate();
            et.Show();
        }
    }
}
