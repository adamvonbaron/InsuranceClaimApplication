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

namespace InsuranceApplication {
    public partial class formFormDemo : Form {
        public formFormDemo() {
            InitializeComponent();
        }

        public string username = null;

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void formFormDemo_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'insuranceClaimDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.insuranceClaimDataSet.users);

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e) {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e) {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e) {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e) {

        }

        private void txtRank_TextChanged(object sender, EventArgs e) {

        }

        private void txtCreation_TextChanged(object sender, EventArgs e) {

        }

        private void txtClaims_TextChanged(object sender, EventArgs e) {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnSubmit_Click(object sender, EventArgs e) {

        }
    }
}
