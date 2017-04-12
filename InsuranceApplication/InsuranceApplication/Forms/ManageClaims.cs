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

namespace InsuranceApplication
{
    public partial class ManageClaims : Form
    {
        ClaimManager claimManager;
        string[] status =
        {
            "New",
            "Received-Not Estimated",
            "Received-Estimated",
            "Fully Reviewed"
        };

        public ManageClaims(ClaimManager claimManager)
        {
            this.claimManager = claimManager;
            InitializeComponent();
        }

        private void ManageClaims_Load(object sender, EventArgs e)
        {
            foreach (string status in status)
                cboStatus.Items.Add(status);

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (User.UpdateClaimStatus(int.Parse(txtID.Text), cboStatus.SelectedIndex))
            {
                MessageBox.Show("Update claim status successfully.", "Message", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            lvClaims.Clear();
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
    }
    
}
