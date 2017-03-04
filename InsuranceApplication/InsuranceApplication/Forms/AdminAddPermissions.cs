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
        Admin admin;
        string[] ranks =
        {
            "Admin",
            "Finance Manager",
            "Claim Manager",
            "Client"
        };
        public AdminAddPermissions(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            admin.UpdatePermissions(txtUsername.Text, (UserType) cboRank.SelectedIndex + 1);
            MessageBox.Show("Updated Rank to " + ranks[cboRank.SelectedIndex]);
        }

        private void AdminAddPermissions_Load(object sender, EventArgs e)
        {
            foreach(string rank in ranks)
                cboRank.Items.Add(rank);
        }
    }
}
