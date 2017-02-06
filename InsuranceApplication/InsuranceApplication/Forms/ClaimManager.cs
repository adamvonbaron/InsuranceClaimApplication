using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceApplication.Forms
{
    public partial class ClaimManager : Form
    {
        public ClaimManager()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            this.Close();
            Forms.ClaimManagerEditProfile f3 = new Forms.ClaimManagerEditProfile();
            f3.Show();
        }

        private void btnViewClientProfile_Click(object sender, EventArgs e)
        {
            this.Close();
            Forms.ClaimManagerViewClientProfile f3 = new Forms.ClaimManagerViewClientProfile();
            f3.Show();
        }
    }
}
