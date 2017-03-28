using System;
using System.Windows.Forms;
using InsuranceApplication.Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InsuranceApplication.Forms
{
    public partial class FinanceManagerHome : Form
    {
        FinanceManager financeManager;
        public FinanceManagerHome(FinanceManager financeManager)
        {
            this.financeManager = financeManager;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditUserProfile f3 = new EditUserProfile(financeManager.GetUserData());
            f3.Show();
        }

        private void btnViewClientProfile_Click(object sender, EventArgs e)
        {
            ViewProfile f3 = new ViewProfile(financeManager);
            f3.Show();
        }

        private void FinanceManagerHome_Load(object sender, EventArgs e)
        {
            lblCurUserInfo.Text = "Logged in as: " + financeManager.UserName + "      Rank: Finance Manager";
            lblFinanceManagerHome.Text = "Welcome, " + financeManager.FirstName + " " + financeManager.LastName;

            lvMessages.View = View.Details;
            DataTable messages = User.GetMessages(financeManager.UserName);
            lvMessages.Columns.Add("From", 75);
            lvMessages.Columns.Add("Date", 125);
            lvMessages.Columns.Add("Subject", 500);
            lvMessages.Columns.Add("Message", 500);
            for (int i = 0; i < messages.Rows.Count; i++)
            {
                DataRow dr = messages.Rows[i];
                ListViewItem curItem = new ListViewItem(dr[1].ToString());
                curItem.SubItems.Add(dr[2].ToString());
                curItem.SubItems.Add(dr[3].ToString());
                curItem.SubItems.Add(dr[4].ToString());
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

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            ViewUserProfile vup = new ViewUserProfile(txtViewUsername.Text);
            vup.ShowDialog();
        }

        private void btnViewClear_Click(object sender, EventArgs e)
        {
            txtViewUsername.Clear();
        }

        private void btnViewClientList_Click(object sender, EventArgs e)
        {
            ViewClientList vcl = new ViewClientList();
            vcl.ShowDialog();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Classes.Message message = new Classes.Message
            {
                To = txtTo.Text,
                From = financeManager.UserName,
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
    }
}
