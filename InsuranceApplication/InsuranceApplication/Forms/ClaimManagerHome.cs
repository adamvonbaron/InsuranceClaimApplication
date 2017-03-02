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

namespace InsuranceApplication.Forms
{
    public partial class ClaimManagerHome : Form
    {
        public string Username, Firstname, Lastname;
        public ClaimManagerHome(string firstname, string lastname, string username)
        {
            InitializeComponent();
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Username = username;
            this.lblClientManagerTitle.Text = "Welcome, " + firstname + " " + lastname;
            this.lblCurUserInfo.Text = "Logged in as: " + username + "      Rank: Admin";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            this.Close();
            EditUserProfile f3 = new EditUserProfile(User.GetUserData(Username));
            f3.Show();
        }

        private void btnViewClientProfile_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewProfile f3 = new ViewProfile(new Client(User.NullUserData));
            f3.Show();
        }
    }
}
