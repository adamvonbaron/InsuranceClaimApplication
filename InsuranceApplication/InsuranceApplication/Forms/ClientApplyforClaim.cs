using System;
using System.Windows.Forms;
using InsuranceApplication.Classes;

namespace InsuranceApplication.Forms
{
    public partial class ClientApplyforClaim : Form
    {
        Client client = null;
        public ClientApplyforClaim(Client client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            Claim claim = new Claim
            {
                UserName = client.UserName,
                Date = DateTime.Now,
                Status = 0,
                Content = txtClaim.Text,
                Amount = 0,
            };
            if (client.ApplyForClaim(claim)) {
                MessageBox.Show("Claim sent successfully.", "Send Claim", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                this.Close();
            } else
                MessageBox.Show("Error sending claim.", "Send Claim", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
        }
    }
}
