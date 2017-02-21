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

namespace InsuranceApplication.Forms {
    public partial class EditUserProfile : Form {
        libsql database = new libsql();
        public EditUserProfile(string username) {
            InitializeComponent();
            User curUser = database.GetUserData(username);
            txtUpdateFirstname.Text = curUser.FirstName;
            txtUpdateLastname.Text = curUser.LastName;
            txtUpdateUsername.Text = curUser.UserName;
            txtUpdatePassword.Text = curUser.Password;
            dtpBirthday.Text = curUser.Birthday;
            txtUpdatePhone.Text = curUser.Phonenumber;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e) {
            if (!database.UpdateUser(txtUpdateFirstname.Text, txtUpdateLastname.Text,
                                txtUpdateUsername.Text, txtUpdatePassword.Text,
                                dtpBirthday.Text, txtUpdatePhone.Text, int.Parse(txtRank.Text)))
                MessageBox.Show("error updating user.", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
