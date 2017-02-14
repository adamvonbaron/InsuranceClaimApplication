﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InsuranceApplication.Classes;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace InsuranceApplication {
    public partial class formFormDemo : Form {
        libsql database = new libsql();
        public formFormDemo() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void formFormDemo_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'insuranceClaimDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.insuranceClaimDataSet.users);

        }

        private void btnUpdateProfile_Click(object sender, EventArgs e) {
            if (!database.UpdateUser(txtFirstName.Text, txtLastName.Text,
                                txtUserName.Text, txtPassword.Text,
                                dtpBirthday.Text, txtPhoneNumber.Text))
                MessageBox.Show("error updating user.", "Error", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSendMessage_Click(object sender, EventArgs e) {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = database.conn;
            cmd.CommandText = @"insert into messages ([to], [from], [date], subject, message)
                                values(@to, @from, @date, @subject, @message);";
            cmd.Parameters.AddWithValue("@to", txtTo.Text);
            cmd.Parameters.AddWithValue("@from", txtFrom.Text);
            cmd.Parameters.AddWithValue("@date", txtDate.Text);
            cmd.Parameters.AddWithValue("@subject", txtSubject.Text);
            cmd.Parameters.AddWithValue("@message", txtMessage.Text);
            database.conn.Open();
            cmd.ExecuteNonQuery();
            database.conn.Close();
        }

        private void btnGetUserInfo_Click(object sender, EventArgs e) {
            
        }

        /* example of registration for logic stuff */
        private void btnRegisterUser_Click(object sender, EventArgs e) {
            if (!database.RegisterUser(txtFirstName.Text, txtLastName.Text,
                                       txtUserName.Text, txtPassword.Text,
                                       dtpBirthday.Text, txtPhoneNumber.Text))
                MessageBox.Show("Error registering user.", "Error", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //send claim button method
        private void btnSendClaim_Click(object sender, EventArgs e)
        {
            database.SendClaim(txtClaimUserName.Text, dtpClaimDate.Text, 
                               txtClaimStatus.Text, txtWriteClaim.Text);
        }
    }
}
