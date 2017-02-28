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
    public partial class AdminAddPermissions : Form
    {
        libsql database = new libsql();
        public AdminAddPermissions()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (cboRank.SelectedIndex == 0)
            {
                MessageBox.Show("Update Rank to Admin");
                database.UpdateRank(txtUsername.Text, 1);
            }
                
            if (cboRank.SelectedIndex == 1)
            {
                MessageBox.Show("Updated Rank to Finance Manager");
                database.UpdateRank(txtUsername.Text, 2);
            }
                
            if (cboRank.SelectedIndex == 2)
            {
                MessageBox.Show("Updated Rank to Claim Manager");
                database.UpdateRank(txtUsername.Text, 3);
            }
                
            if (cboRank.SelectedIndex == 3)
            {
                MessageBox.Show("Updated Rank to Client");
                database.UpdateRank(txtUsername.Text, 4);
            }
                
                
        }

        private void AdminAddPermissions_Load(object sender, EventArgs e)
        {
            string[] ranks = { "Admin", "Finance Manager", "Claim Manager", "Client" };
            foreach(string rank in ranks)
            {
                cboRank.Items.Add(rank);
            }
        }
    }
}
