using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InsuranceApplication.Forms;
using InsuranceApplication.Classes;

namespace InsuranceApplication.Forms
{
    public partial class AdminHome : Form
    {
        Admin admin;
        string[] ranks =
        {
            "Admin",
            "Finance Manager",
            "Claim Manager",
            "Client"
        };
        public AdminHome(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            lblAdminTitle.Text = "Welcome, " + admin.FirstName + " " + admin.LastName;
            lblCurUserInfo.Text = "Logged in as: " + admin.UserName + "      Rank: Admin";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            foreach (string rank in ranks)
                cboRank.Items.Add(rank);

            lvMessages.View = View.Details;
            List<Classes.Message> messages = User.GetMessages(admin.UserName);
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


            lvClaims.View = View.Details;
            DataTable claims = User.GetClaims();
            lvClaims.Columns.Add("date", 85);
            lvClaims.Columns.Add("username", 85);
            lvClaims.Columns.Add("status", 50);
            lvClaims.Columns.Add("amount", 50);
            lvClaims.Columns.Add("claim", 100);
            lvClaims.Columns.Add("id", 50);
            for (int i = 0; i < claims.Rows.Count; i++)
            {
                DataRow dr = claims.Rows[i];
                ListViewItem curItem = new ListViewItem(dr[0].ToString());
                curItem.SubItems.Add(dr[1].ToString());
                curItem.SubItems.Add(dr[2].ToString());
                curItem.SubItems.Add(dr[3].ToString());
                curItem.SubItems.Add(dr[4].ToString());
                curItem.SubItems.Add(dr[5].ToString());
                lvClaims.Items.Add(curItem);
            }
        }

        private void btnPermissionsEnter_Click(object sender, EventArgs e)
        {
            admin.UpdatePermissions(txtPermissionsUsername.Text, (UserType)cboRank.SelectedIndex + 1);
            MessageBox.Show("Updated Rank to " + ranks[cboRank.SelectedIndex]);
        }

        private void btnDeleteEnter_Click(object sender, EventArgs e)
        { 
            admin.DeleteUser(txtPermissionsUsername.Text);
            MessageBox.Show("Deleted User " + txtDeleteUsername.Text);
        }

        private void btnPermissionsClear_Click(object sender, EventArgs e)
        {
            txtPermissionsUsername.Clear();
            cboRank.SelectedIndex = -1;
        }

        private void btnDeleteClear_Click(object sender, EventArgs e)
        {
            txtDeleteUsername.Clear();
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

        private void btnRegisterEnter_Click(object sender, EventArgs e)
        {
            Client client = new Client(new UserData
            {
                FirstName = txtRegisterFirstname.Text,
                LastName = txtRegisterLastname.Text,
                UserName = txtRegisterUsername.Text,
                Password = txtRegisterPassword.Text,
                Birthday = dtpRegisterDateOfBirth.Value.ToString(),
                Phonenumber = txtRegisterPhone.Text,
                Type = UserType.Client
            });
            if (Admin.RegisterUser(client))
                MessageBox.Show("Registered user successfully.", "Register",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error registering user.", "Register",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRegisterClear_Click(object sender, EventArgs e)
        {
            txtRegisterFirstname.Clear();
            txtRegisterLastname.Clear();
            txtRegisterUsername.Clear();
            txtRegisterPassword.Clear();
            txtRegisterPhone.Clear();
            dtpRegisterDateOfBirth.ResetText();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            SendMessage sendmessage = new SendMessage(admin.UserName, "", "", false);
            sendmessage.ShowDialog();
        }

        private void lvMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Classes.Message message = User.GetMessage(lvMessages.SelectedItems[0].SubItems[0].Text);
                ViewMessage vm = new ViewMessage(admin, message.From, message.Subject, message.Date, message.Content);
                vm.ShowDialog();
            }
            catch (Exception ex)
            {
            
            }
        }
    }
}
