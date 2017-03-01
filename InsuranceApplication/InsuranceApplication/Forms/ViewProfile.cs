using System;
using System.Windows.Forms;
using InsuranceApplication.Classes;

namespace InsuranceApplication.Forms
{
    public partial class ViewProfile : Form
    {
        User user;
        public ViewProfile(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void ClaimManagerViewClientProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewProfile_Click(object sender, EventArgs e) {
            ViewUserProfile vup = new ViewUserProfile(user);
            vup.ShowDialog();
        }
    }
}
