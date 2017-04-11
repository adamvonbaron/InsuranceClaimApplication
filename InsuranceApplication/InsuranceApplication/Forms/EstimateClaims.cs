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
    public partial class EstimateClaims : Form
    {
        public EstimateClaims()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EstimateClaims_Load(object sender, EventArgs e)
        {
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

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(User.UpdateClaimAmount(int.Parse(txtID.Text), int.Parse(txtAmount.Text)))
            {
                MessageBox.Show("Update claim amount successfully.", "Message", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            lvClaims.Clear();
            lvClaims.View = View.Details;
            DataTable claims = User.GetClaims();
            lvClaims.Columns.Add("date", 85);
            lvClaims.Columns.Add("username", 85);
            lvClaims.Columns.Add("status", 100);
            lvClaims.Columns.Add("claim", 200);
            lvClaims.Columns.Add("id", 50);
            for (int i = 0; i < claims.Rows.Count; i++)
            {
                DataRow dr = claims.Rows[i];
                ListViewItem curItem = new ListViewItem(dr[0].ToString());
                curItem.SubItems.Add(dr[1].ToString());
                curItem.SubItems.Add(dr[2].ToString());
                curItem.SubItems.Add(dr[3].ToString());
                curItem.SubItems.Add(dr[4].ToString());
                lvClaims.Items.Add(curItem);
            }
        }
    }
}
