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
        public ForgotPassword(string username)
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtNewPassword.Clear();
            Random rnd = new Random();
            int password = rnd.Next(10000, 15000);
            txtNewPassword.Text = password.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            libsql.UpdatePassword(txtUsername.Text, txtNewPassword.Text);
        }
    }
}
