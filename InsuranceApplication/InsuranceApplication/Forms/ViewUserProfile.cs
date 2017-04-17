using System;
using System.Windows.Forms;
using InsuranceApplication.Classes;

namespace InsuranceApplication.Forms
{
    public partial class ViewUserProfile : Form
    {
        public UserData userdata;
        public ViewUserProfile(string username)
        {
            InitializeComponent();
            userdata = User.GetUserData(username);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditUser_Click(object sender, EventArgs e) {
            
            EditUserProfile eup = new EditUserProfile(userdata);
            eup.ShowDialog();
        }

        private void ViewUserProfile_Load(object sender, EventArgs e)
        {
            lblFirstName.Text = "First Name: " + userdata.FirstName;
            lblLastName.Text = "Last Name: " + userdata.LastName;
            lblUsername.Text = "Username: " + userdata.UserName;
            lblBirthday.Text = "Birthday: " + userdata.Birthday;
            lblPhoneNumber.Text = "Phone Number: " + userdata.Phonenumber;
        }
    }
}
