﻿using System;
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
    public partial class ClaimManagerViewClientProfile : Form
    {
        string Username;
        public ClaimManagerViewClientProfile(string username)
        {
            InitializeComponent();
            this.Username = username;
        }

        private void ClaimManagerViewClientProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewProfile_Click(object sender, EventArgs e) {
            ViewUserProfile vup = new ViewUserProfile(txtUsername.Text);
            vup.ShowDialog();
        }
    }
}
