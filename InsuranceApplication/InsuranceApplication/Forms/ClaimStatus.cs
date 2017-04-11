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
    public partial class ClaimStatus : Form
    {
        Client client;
        public ClaimStatus(Client client)
        {
            this.client = client;  
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClaimStatus_Load(object sender, EventArgs e)
        {
            lvClaimStatus.View = View.Details;
            DataTable claims = User.GetClaimStatus(client.UserName);
            lvClaimStatus.Columns.Add("date", 85);
            lvClaimStatus.Columns.Add("username", 85);
            lvClaimStatus.Columns.Add("status", 100);
            lvClaimStatus.Columns.Add("claim", 200);
            lvClaimStatus.Columns.Add("id", 50);
            for (int i = 0; i < claims.Rows.Count; i++)
            {
                DataRow dr = claims.Rows[i];
                ListViewItem curItem = new ListViewItem(dr[0].ToString());
                curItem.SubItems.Add(dr[1].ToString());
                curItem.SubItems.Add(dr[2].ToString());
                curItem.SubItems.Add(dr[3].ToString());
                curItem.SubItems.Add(dr[4].ToString());
                lvClaimStatus.Items.Add(curItem);
            }
        }
    }
}
