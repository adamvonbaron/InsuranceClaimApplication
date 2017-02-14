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
    public partial class UserEditProfile : Form
    {
        public UserEditProfile()
        {
            InitializeComponent();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            btnUpdateInfo.Visible = false;
            btnSaveInfo.Visible = true;
            txtInfo.Visible = true;
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            lblInfo.Text = txtInfo.Text;
            txtInfo.Clear();
            btnSaveInfo.Visible = false;
            txtInfo.Visible = false;
            btnUpdateInfo.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
