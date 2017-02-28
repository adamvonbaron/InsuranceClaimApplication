using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InsuranceApplication.ClassesRefine;
using InsuranceApplication.Forms;

namespace InsuranceApplication.Forms {
    public partial class EditUserProfile : Form {
        int rank;
        public EditUserProfile(User user) {
            InitializeComponent();
            User curUser = user;
            switch(user.Rank)
            {
                //case 1:
                //    public Admin curUser = user;
                case 2:
                    curUser = new FinanceManager();
                //case 3:
                //    curUser = new ClientManager();
                case 4:
                    curUser = new Client();
            }
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

            if (!User.UpdateProfile(txtUpdateFirstname.Text, txtUpdateLastname.Text,
                                txtUpdateUsername.Text, txtUpdatePassword.Text,
                                dtpBirthday.Text, txtUpdatePhone.Text, rank))
                MessageBox.Show("error updating user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EditUserProfile_Load(object sender, EventArgs e)
        {
            
        }
    }
}
