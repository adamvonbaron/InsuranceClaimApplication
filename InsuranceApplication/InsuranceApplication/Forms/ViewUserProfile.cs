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

namespace InsuranceApplication.Forms
{
    public partial class ViewUserProfile : Form
    {
        libsql database = new libsql();
        string Username;
        public ViewUserProfile(string username)
        {
            InitializeComponent();
            this.Username = username;
            User curUser = database.GetUserData(Username);
            lblFirstName.Text = "First Name: " + curUser.FirstName;
            lblLastName.Text = "Last Name: " + curUser.LastName;
            lblUsername.Text = "Username: " + curUser.UserName;
            lblBirthday.Text = "Birthday: " + curUser.Birthday;
            lblPhoneNumber.Text = "Phone Number: " + curUser.Phonenumber;
            lblNumOfClaims.Text = "# of Claims: 0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditUser_Click(object sender, EventArgs e) {
            EditUserProfile eup = new EditUserProfile(Username);
            eup.ShowDialog();
        }
    }
}
