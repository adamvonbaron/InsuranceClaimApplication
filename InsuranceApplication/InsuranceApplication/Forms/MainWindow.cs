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
            UserType usertype = User.Login(txtUsername.Text, txtPassword.Text);
            User user;
            switch(usertype)
            {
                case UserType.Admin:
                    //user = new Admin();
                    break;
                case UserType.FinanceManager:
                    user = new FinanceManager(txtUsername.Text, txtPassword.Text);
                    break;
                case UserType.ClientManager:
                    //user = new ClientManager(txtUsername.Text, txtPassword.Text);
                    break;
                case UserType.Client:
                    user = new Client(txtUsername.Text, txtPassword.Text);
                    break;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register f4 = new Register();
            f4.Show();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPassword f3 = new ForgotPassword(txtUsername.Text);
            f3.Show();
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            formFormDemo ffd = new formFormDemo();
            ffd.Show();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //EditTemplate et = new EditTemplate();
            //et.Show();
        }
    }
}
