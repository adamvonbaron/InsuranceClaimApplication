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
    public partial class FinanceManagerEditProfile : Form
    {
        public FinanceManagerEditProfile()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Forms.FinanceManagerHome f3 = new Forms.FinanceManagerHome();
            f3.Show();
        }
    }
}