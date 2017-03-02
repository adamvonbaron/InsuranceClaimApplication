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
            object user = null;
            Form home = null;
            switch(usertype)
            {
                case UserType.Admin:
                    user = new Admin(txtUsername.Text, txtPassword.Text);
                    home = new AdminHome((Admin)user);
                    break;
                case UserType.FinanceManager:
                    user = new FinanceManager(txtUsername.Text, txtPassword.Text);
                    home = new FinanceManagerHome((FinanceManager) user);
                    break;
                case UserType.ClientManager:
                    //user = new ClientManager(txtUsername.Text, txtPassword.Text);
                    break;
                case UserType.Client:
                    user = new Client(txtUsername.Text, txtPassword.Text);
                    home = new ClientHome((Client) user);
                    break;
            }
            this.Hide();
            home.ShowDialog();
            txtPassword.Text = string.Empty;
            this.Show();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            //EditTemplate et = new EditTemplate();
            //et.Show();
        }
    }
}
