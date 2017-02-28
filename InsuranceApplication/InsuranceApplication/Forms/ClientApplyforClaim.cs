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
using InsuranceApplication.Forms;

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
            /* replace database call with user call */
            if (database.SendClaim(Username, dtpClaimDate.Text,
                               txtStatus.Text, txtClaim.Text)) {
                MessageBox.Show("Claim sent successfully.", "Send Claim", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                this.Close();
            } else
                MessageBox.Show("Error sending claim.", "Send Claim", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
        }
    }
}
