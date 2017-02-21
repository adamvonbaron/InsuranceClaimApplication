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
        public string Username;
        public string Firstname;
        public string Lastname;
        public ClientHome(string firstname, string lastname, string username)
        {
            InitializeComponent();
            this.lblClientHome.Text = "Welcome, " + firstname + " " + lastname;
            this.lblCurUserInfo.Text = "Logged in as: " + username + "      Rank: Client";
            this.Username = username;
            this.Firstname = firstname;
            this.Lastname = lastname;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditUserProfile f3 = new EditUserProfile(Username);
            f3.ShowDialog();
        }

        private void btnApplyForClaim_Click(object sender, EventArgs e) {
            ClientApplyforClaim cac = new ClientApplyforClaim(Username);
            cac.ShowDialog();
        }

        private void btnViewMessages_Click(object sender, EventArgs e) {
            ViewMessagesForm vmf = new ViewMessagesForm(Username);
            vmf.ShowDialog();
        }
    }
}
