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
        string[] ranks =
        {
            "Admin",
            "Finance Manager",
            "Claim Manager",
            "Client"
        };
        public AdminHome(Admin admin) {
            InitializeComponent();
            this.admin = admin;
            lblAdminTitle.Text = "Welcome, " + admin.FirstName + " " + admin.LastName;
            lblCurUserInfo.Text = "Logged in as: " + admin.UserName + "      Rank: Admin";
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnCreateClientFolder_Click(object sender, EventArgs e) {

        }

        private void btnRegisterCMFM_Click(object sender, EventArgs e) {
            Register register = new Register();
            register.ShowDialog();
        }

        private void btnMessageCenter_Click(object sender, EventArgs e) {
            MessageCenter mc = new MessageCenter(admin);
            mc.ShowDialog();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            foreach(string rank in ranks)
                cboRank.Items.Add(rank);
        }

        private void btnPermissionsEnter_Click(object sender, EventArgs e)
        {
            admin.UpdatePermissions(txtPermissionsUsername.Text, (UserType)cboRank.SelectedIndex + 1);
            MessageBox.Show("Updated Rank to " + ranks[cboRank.SelectedIndex]);
        }

        private void btnDeleteEnter_Click(object sender, EventArgs e)
        {
            admin.DeleteUser(txtPermissionsUsername.Text);
            MessageBox.Show("Deleted User " + txtDeleteUsername.Text);
        }

        private void btnPermissionsClear_Click(object sender, EventArgs e)
        {
            txtPermissionsUsername.Clear();
            cboRank.SelectedIndex = -1;
        }

        private void btnDeleteClear_Click(object sender, EventArgs e)
        {
            txtDeleteUsername.Clear();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            ViewUserProfile vup = new ViewUserProfile(txtViewUsername.Text);
            vup.ShowDialog();
        }

        private void btnViewClear_Click(object sender, EventArgs e)
        {
            txtViewUsername.Clear();
        }

        private void btnRegisterEnter_Click(object sender, EventArgs e)
        {
            Client client = new Client(new UserData
            {
                FirstName = txtRegisterFirstname.Text,
                LastName = txtRegisterLastname.Text,
                UserName = txtRegisterUsername.Text,
                Password = txtRegisterPassword.Text,
                Birthday = dtpRegisterDateOfBirth.Value.ToString(),
                Phonenumber = txtRegisterPhone.Text,
                Type = UserType.Client
            });
            if (Admin.RegisterUser(client))
                MessageBox.Show("Registered user successfully.", "Register",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error registering user.", "Register",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRegisterClear_Click(object sender, EventArgs e)
        {
            txtRegisterFirstname.Clear();
            txtRegisterLastname.Clear();
            txtRegisterUsername.Clear();
            txtRegisterPassword.Clear();
            txtRegisterPhone.Clear();
            dtpRegisterDateOfBirth.ResetText();
        }
    }
}
