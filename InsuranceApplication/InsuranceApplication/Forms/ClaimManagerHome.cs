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

namespace InsuranceApplication.Forms
{
    public partial class ClaimManagerHome : Form
    {
        ClaimManager User { get; set; }
        public ClaimManagerHome(ClaimManager user)
        {
            User = user;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            ViewUserProfile vup = new ViewUserProfile(txtViewUsername.Text);
            vup.ShowDialog();
        }

        private void btnViewClear_Click(object sender, EventArgs e)
        {
            txtViewUsername.Clear();
        }

        private void ClaimManagerHome_Load(object sender, EventArgs e)
        {
            lblCurUserInfo.Text = "Logged in as: " + User.UserName + "      Rank: Finance Manager";
            lblClaimManagerTitle.Text = "Welcome, " + User.FirstName + " " + User.LastName;
        }
    }
}
