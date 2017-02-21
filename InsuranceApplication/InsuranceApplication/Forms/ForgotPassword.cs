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

namespace InsuranceApplication.Forms
{
    public partial class ForgotPassword : Form
    {
        libsql database = new libsql();
        public ForgotPassword(string username)
        {
            InitializeComponent();
            User curUser = database.GetUserData(username);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtNewPassword.Clear();
            Random rnd = new Random();
            int password = rnd.Next(10000, 15000);
            txtNewPassword.Text = password.ToString();

            database.UpdatePassword(txtUsername.Text, txtNewPassword.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
