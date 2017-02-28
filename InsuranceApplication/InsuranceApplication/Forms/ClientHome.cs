using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceApplication.Forms
{
    public partial class ClientHome : Form
    {
        ClassesRefine.Client curClient = null;
        public ClientHome(ClassesRefine.Client client)
        {
            curClient = client;
            InitializeComponent();
            this.lblClientHome.Text = "Welcome, " + curClient.FirstName + " " + curClient.LastName;
            this.lblCurUserInfo.Text = "Logged in as: " + curClient.UserName + "      Rank: Client";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            curClient.EditProfile();
        }

        private void btnApplyForClaim_Click(object sender, EventArgs e) {
            curClient.ApplyForClaim();
        }

        private void btnViewMessages_Click(object sender, EventArgs e) {
            curClient.ViewMessages();
        }
    }
}
