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
using System.Xml.Linq;
using System.Data.SqlClient;

namespace InsuranceApplication {
    public partial class formFormDemo : Form {
        libsql database = new libsql();
        public formFormDemo() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void formFormDemo_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'insuranceClaimDataSet.users' table. 
            // You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.insuranceClaimDataSet.users);
        }

        /* example of updating user info */
        /* TODO: work on example showing how to populate
         * text fields with data from db */
        private void btnUpdateProfile_Click(object sender, EventArgs e) {
            if (!database.UpdateUser(txtFirstName.Text, txtLastName.Text,
                                txtUserName.Text, txtPassword.Text,
                                dtpBirthday.Text, txtPhoneNumber.Text))
                MessageBox.Show("error updating user.", "Error", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /* example of sending a message */
        private void btnSendMessage_Click(object sender, EventArgs e) {
            database.SendMessage(txtTo.Text, txtFrom.Text, txtDate.Text, 
                                 txtSubject.Text, txtMessage.Text);
        }

        //TODO: This.
        private void btnGetUserInfo_Click(object sender, EventArgs e) {
            
        }

        /* example of registration for logic stuff */
        private void btnRegisterUser_Click(object sender, EventArgs e) {
            if (!database.RegisterUser(txtFirstName.Text, txtLastName.Text,
                                       txtUserName.Text, txtPassword.Text,
                                       dtpBirthday.Text, txtPhoneNumber.Text))
                MessageBox.Show("Error registering user.", "Error", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /* example of sending a claim */
        private void btnSendClaim_Click(object sender, EventArgs e)
        {
            database.SendClaim(txtClaimUserName.Text, dtpClaimDate.Text, 
                               txtClaimStatus.Text, txtWriteClaim.Text);
        }
    }
}
