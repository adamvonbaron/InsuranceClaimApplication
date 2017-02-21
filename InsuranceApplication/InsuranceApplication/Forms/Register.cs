﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InsuranceApplication.Classes;
using InsuranceApplication.Forms;

namespace InsuranceApplication.Forms {
    public partial class Register : Form {
        libsql database = new libsql();
        public Register() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e) {
            int rank;
            if (comboBoxRank.SelectedText == "admin")
                rank = 1;
            else if (comboBoxRank.SelectedText == "finance manager")
                rank = 2;
            else if (comboBoxRank.SelectedText == "client manager")
                rank = 3;
            else
                rank = 4;

            if(database.RegisterUser(txtFirstname.Text, txtLastname.Text,
                                  txtUsername.Text, txtPassword.Text,
                                  dtpDateOfBirth.Text, txtPhone.Text, rank))
            {
                MessageBox.Show("Registered user successfully.", "Register",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } else
                MessageBox.Show("Error registering user.", "Register",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);

            database.UpdateRank(txtUsername.Text, rank);
        }
    }
}
