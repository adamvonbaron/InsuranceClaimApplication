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
        public string Username, Firstname, Lastname;
        public ClaimManager(string firstname, string lastname, string username)
        {
            InitializeComponent();
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Username = username;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            this.Close();
            EditUserProfile f3 = new EditUserProfile(Username);
            f3.Show();
        }

        private void btnViewClientProfile_Click(object sender, EventArgs e)
        {
            this.Close();
            EditUserProfile f3 = new EditUserProfile(Username);
            f3.Show();
        }
    }
}
