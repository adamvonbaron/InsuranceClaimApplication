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
        Client client;
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

        private void ClientHome_Load(object sender, EventArgs e)
        {
            this.lblClientHome.Text = "Welcome, " + client.FirstName + " " + client.LastName;
            this.lblCurUserInfo.Text = "Logged in as: " + client.UserName + "      Rank: Client";

            lvMessages.View = View.Details;
            List<Classes.Message> messages = User.GetMessages(client.UserName);
            lvMessages.Columns.Add("ID", 10);
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

            lvManagers.View = View.Details;
            DataTable managers = User.GetManagers();
            lvManagers.Columns.Add("From", 75);
            lvManagers.Columns.Add("Date", 125);
            lvManagers.Columns.Add("Subject", 500);
            lvManagers.Columns.Add("Message", 500);
            for (int i = 0; i < managers.Rows.Count; i++)
            {
                DataRow dr = managers.Rows[i];
                ListViewItem curItem = new ListViewItem(dr[0].ToString());
                curItem.SubItems.Add(dr[1].ToString());
                curItem.SubItems.Add(dr[4].ToString());
                curItem.SubItems.Add(dr[5].ToString());
                lvManagers.Items.Add(curItem);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Classes.Message message = new Classes.Message
            {
                To = txtTo.Text,
                From = client.UserName,
                Date = DateTime.Now.ToString(),
                Subject = txtSubject.Text,
                Content = txtMessage.Text
            };
            if (User.SendMessage(message))
            {
                MessageBox.Show("Message sent successfully.", "Message", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
        }

        private void lvMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            Classes.Message message = User.GetMessage(lvMessages.SelectedItems[0].SubItems[0].Text);
            ViewMessage vm = new ViewMessage(client, message.From, message.Subject, message.Date, message.Content);
            vm.ShowDialog();
        }
    }
}
