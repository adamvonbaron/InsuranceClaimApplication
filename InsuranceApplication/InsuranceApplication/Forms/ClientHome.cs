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
    public partial class ClientHome : Form
    {
        Client client = null;
        public ClientHome(Client client)
        {
            this.client = client;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditUserProfile eup = new EditUserProfile(client.GetUserData());
            eup.ShowDialog();
        }

        private void btnApplyForClaim_Click(object sender, EventArgs e) {
            ClientApplyforClaim cafc = new ClientApplyforClaim(client);
            cafc.ShowDialog();
        }

        private void btnViewMessages_Click(object sender, EventArgs e) {
            ViewMessagesForm vmf = new ViewMessagesForm(client);
            vmf.ShowDialog();
        }

        private void ClientHome_Load(object sender, EventArgs e)
        {
            this.lblClientHome.Text = "Welcome, " + client.FirstName + " " + client.LastName;
            this.lblCurUserInfo.Text = "Logged in as: " + client.UserName + "      Rank: Client";
        }
    }
}
