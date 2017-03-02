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
        Admin admin;
        public AdminHome(Admin admin) {
            InitializeComponent();
            this.admin = admin;
            lblAdminTitle.Text = "Welcome, " + admin.FirstName + " " + admin.LastName;
            lblCurUserInfo.Text = "Logged in as: " + admin.UserName + "      Rank: Admin";
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnViewUserData_Click(object sender, EventArgs e) {
            ViewProfile f3 = new ViewProfile(admin);
            f3.ShowDialog();
        }

        private void btnAddPermissions_Click(object sender, EventArgs e) {
            AdminAddPermissions f4 = new AdminAddPermissions(admin);
            f4.ShowDialog();
        }

        private void btnCreateClientFolder_Click(object sender, EventArgs e) {

        }

        private void btnRegisterCMFM_Click(object sender, EventArgs e) {
            Register register = new Register();
            register.ShowDialog();
        }

        private void btnEditProfile_Click(object sender, EventArgs e) {
            EditUserProfile f2 = new EditUserProfile(User.GetUserData(admin.UserName));
            f2.ShowDialog();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e) {
            Register register = new Register();
            register.ShowDialog();
        }

        private void btnMessageCenter_Click(object sender, EventArgs e) {
            MessageCenter mc = new MessageCenter(admin);
            mc.ShowDialog();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser du = new DeleteUser(admin);
            du.ShowDialog();
        }
    }
}
