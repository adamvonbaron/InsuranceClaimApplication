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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewUserData_Click(object sender, EventArgs e)
        {
            this.Close();
            Forms.AdminViewUserData f3 = new Forms.AdminViewUserData();
            f3.Show();
        }

        private void btnAddPermissions_Click(object sender, EventArgs e)
        {
            this.Close();
            Forms.AdminAddPermissions f4 = new Forms.AdminAddPermissions();
            f4.Show();
        }

        private void btnCreateClientFolder_Click(object sender, EventArgs e)
        {
            this.Close();
            Forms.AdminCreateClientFolder f5 = new Forms.AdminCreateClientFolder();
            f5.Show();
        }

        private void btnRegisterCMFM_Click(object sender, EventArgs e)
        {
            this.Close();
            Forms.AdminRegisterCMFM f6 = new Forms.AdminRegisterCMFM();
            f6.Show();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            this.Close();
            Forms.AdminEditProfile f2 = new Forms.AdminEditProfile();
            f2.Show();
        }
    }
}
