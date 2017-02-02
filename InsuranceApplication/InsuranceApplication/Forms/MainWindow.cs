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

            //link login to admin home page
            Forms.AdminHome f1 = new Forms.AdminHome();
            f1.Show();

            //link login to client home page
            Forms.ClientHome f2 = new Forms.ClientHome();
            f2.Show();

            //link login to client manager home page
            Forms.ClientManagerHome f3 = new Forms.ClientManagerHome();
            f3.Show();

            //link login to finance manager home page
            Forms.FinanceManagerHome f4 = new Forms.FinanceManagerHome();
            f4.Show();
        }
    }
}
