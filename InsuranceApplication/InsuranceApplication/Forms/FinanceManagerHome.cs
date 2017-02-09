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
    public partial class FinanceManagerHome : Form
    {
        public FinanceManagerHome()
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
            Forms.FinanceManagerEditProfile f3 = new Forms.FinanceManagerEditProfile();
            f3.Show();
        }

        private void btnViewClientProfile_Click(object sender, EventArgs e)
        {
            this.Close();
            Forms.FinanceManagerViewClientProfile f3 = new Forms.FinanceManagerViewClientProfile();
            f3.Show();
        }
    }
}
