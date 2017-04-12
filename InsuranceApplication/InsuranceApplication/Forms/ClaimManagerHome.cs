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
        ClaimManager claimManager;
        public ClaimManagerHome(ClaimManager claimManager)
        {
            this.claimManager = claimManager;
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
            lblCurUserInfo.Text = "Logged in as: " + claimManager.UserName + "      Rank: Claim Manager";
            lblClaimManagerTitle.Text = "Welcome, " + claimManager.FirstName + " " + claimManager.LastName;

            lvMessages.View = View.Details;
            List<Classes.Message> messages = User.GetMessages(claimManager.UserName);
            lvMessages.Columns.Add("ID", 50);
            lvMessages.Columns.Add("From", 75);
            lvMessages.Columns.Add("Date", 125);
            lvMessages.Columns.Add("Subject", 500);
            foreach (Classes.Message message in messages)
            {
                ListViewItem curItem = new ListViewItem(message.Id.ToString());
                curItem.SubItems.Add(message.From);
                curItem.SubItems.Add(message.Date);
                curItem.SubItems.Add(message.Subject);
                lvMessages.Items.Add(curItem);
            }

            lvClients.View = View.Details;
            DataTable clients = User.GetClients();
            lvClients.Columns.Add("firstname", 85);
            lvClients.Columns.Add("lastname", 85);
            lvClients.Columns.Add("birthday", 150);
            lvClients.Columns.Add("phonenumber", 75);
            for (int i = 0; i < clients.Rows.Count; i++)
            {
                DataRow dr = clients.Rows[i];
                ListViewItem curItem = new ListViewItem(dr[0].ToString());
                curItem.SubItems.Add(dr[1].ToString());
                curItem.SubItems.Add(dr[4].ToString());
                curItem.SubItems.Add(dr[5].ToString());
                lvClients.Items.Add(curItem);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage sm = new SendMessage(claimManager, "", "", false);
            sm.ShowDialog();
        }

        private void lvMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Classes.Message message = User.GetMessage(lvMessages.SelectedItems[0].SubItems[0].Text);
                ViewMessage vm = new ViewMessage(claimManager, message.From, message.Subject, message.Date, message.Content);
                vm.ShowDialog();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnManageClaims_Click(object sender, EventArgs e)
        {
            ManageClaims mc = new ManageClaims(claimManager);
            mc.ShowDialog();
        }
    }
}

