using System;
using System.Windows.Forms;
using InsuranceApplication.Classes;

namespace InsuranceApplication.Forms
{
    public partial class ViewUserProfile : Form
    {
        Admin admin;
        FinanceManager financemanager;
        public ViewUserProfile(UserType type)
        {
            InitializeComponent();
            admin = user;
            financemanager = null;
            lblFirstName.Text = "First Name: " + admin.FirstName;
            lblLastName.Text = "Last Name: " + admin.LastName;
            lblUsername.Text = "Username: " + admin.UserName;
            lblBirthday.Text = "Birthday: " + admin.Birthday;
            lblPhoneNumber.Text = "Phone Number: " + admin.Phonenumber;
            lblNumOfClaims.Text = "# of Claims: 0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditUser_Click(object sender, EventArgs e) {
            
            EditUserProfile eup = new EditUserProfile();
            eup.ShowDialog();
        }

        private void ViewUserProfile_Load(object sender, EventArgs e)
        {
            
        }
    }
}
