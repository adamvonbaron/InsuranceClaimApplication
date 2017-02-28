using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InsuranceApplication.Forms;
using InsuranceApplication.Classes;

namespace InsuranceApplication.Forms
{
    public partial class FinanceManagerHome : Form
    {
        libsql database = new libsql();
        public string Username;
        public string Firstname;
        public string Lastname;
        public FinanceManagerHome(string firstname, string lastname, string username)
        {
            InitializeComponent();
            this.Username = username;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.lblCurUserInfo.Text = "Logged in as: " + username + "      Rank: Finance Manager";
            this.lblFinanceManagerHome.Text = "Welcome, " + firstname + " " + lastname;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            this.Close();
            Forms.FinanceManagerEditProfile f3 = new Forms.FinanceManagerEditProfile();
            f3.Show();
        }

        private void btnViewClientProfile_Click(object sender, EventArgs e)
        {
            this.Close();
            Forms.ViewProfile f3 = new Forms.ViewProfile(Username);
            f3.Show();
        }
    }
}
