using System;
using System.Windows.Forms;
using InsuranceApplication.Classes;

namespace InsuranceApplication.Forms
{
    public partial class FinanceManagerHome : Form
    {
        FinanceManager User { get; set; }
        public FinanceManagerHome(FinanceManager user)
        {
            User = user;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditUserProfile f3 = new EditUserProfile(User.GetUserData());
            f3.Show();
        }

        private void btnViewClientProfile_Click(object sender, EventArgs e)
        {
            ViewProfile f3 = new ViewProfile(User);
            f3.Show();
        }

        private void FinanceManagerHome_Load(object sender, EventArgs e)
        {
            lblCurUserInfo.Text = "Logged in as: " + User.UserName + "      Rank: Finance Manager";
            lblFinanceManagerHome.Text = "Welcome, " + User.FirstName + " " + User.LastName;
        }
    }
}
