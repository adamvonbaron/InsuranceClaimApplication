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

namespace InsuranceApplication.Forms {
    public partial class AdminHome : Form {
        libsql database = new libsql();
        public string Username;
        public string Firstname;
        public string Lastname;
        public AdminHome(string firstname, string lastname, string username) {
            InitializeComponent();
            this.Username = username;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.lblAdminTitle.Text = "Welcome, " + firstname + " " + lastname;
            this.lblCurUserInfo.Text = "Logged in as: " + username + "      Rank: Admin";
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnViewUserData_Click(object sender, EventArgs e) {
            ViewProfile f3 = new ViewProfile(Username);
            f3.ShowDialog();
        }

        private void btnAddPermissions_Click(object sender, EventArgs e) {
            AdminAddPermissions f4 = new AdminAddPermissions();
            f4.ShowDialog();
        }

        private void btnCreateClientFolder_Click(object sender, EventArgs e) {
            AdminCreateClientFolder f5 = new AdminCreateClientFolder();
            f5.ShowDialog();
        }

        private void btnRegisterCMFM_Click(object sender, EventArgs e) {
            AdminRegisterCMFM f6 = new AdminRegisterCMFM();
            f6.ShowDialog();
        }

        private void btnEditProfile_Click(object sender, EventArgs e) {
            EditUserProfile f2 = new EditUserProfile(Username);
            f2.ShowDialog();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e) {
            Register register = new Register();
            register.ShowDialog();
        }

        private void btnMessageCenter_Click(object sender, EventArgs e) {
            MessageCenter mc = new MessageCenter(Username);
            mc.ShowDialog();
        }
    }
}
