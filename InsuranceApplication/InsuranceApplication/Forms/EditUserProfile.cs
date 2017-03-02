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

        public UserData userdata;
        public EditUserProfile(UserData userdata) {
            InitializeComponent();
            this.userdata = userdata;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e) {

            if (!Admin.UpdateUser(userdata))
                MessageBox.Show("error updating user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EditUserProfile_Load(object sender, EventArgs e)
        {
            txtUpdateFirstname.Text = userdata.FirstName;
            txtUpdateLastname.Text = userdata.LastName;
            txtUpdateUsername.Text = userdata.UserName;
            txtUpdatePassword.Text = userdata.Password;
            dtpBirthday.Text = userdata.Birthday;
            txtUpdatePhone.Text = userdata.Phonenumber;
        }
    }
}
