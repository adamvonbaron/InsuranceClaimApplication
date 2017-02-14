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
    public partial class ClientEditProfile : Form {
        libsql database = new libsql();
        public ClientEditProfile(string username) {
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
    }
}
