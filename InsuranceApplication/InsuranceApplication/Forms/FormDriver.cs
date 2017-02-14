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
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = database.conn;
            cmd.CommandText = @"update users set firstname = @firstname, lastname = @lastname, username = @username, password = @password, birthday = @birthday, phonenumber = @phonenumber Where username = @oldusername;";
            cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@lastname", txtLastName.Text);
            cmd.Parameters.AddWithValue("@username", txtUserName.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@birthday", dtpBirthday.Text);
            cmd.Parameters.AddWithValue("@phonenumber", txtPhoneNumber.Text);
            cmd.Parameters.AddWithValue("@oldusername", txtUserName.Text);
            database.conn.Open();
            cmd.ExecuteNonQuery();
            database.conn.Close();
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
            database.GetUser(txtGetUser.Text);
        }

        /* example of registration for logic stuff */
        private void btnRegisterUser_Click(object sender, EventArgs e) {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = database.conn;
            cmd.CommandText = @"insert into users (firstname, lastname, username, password, birthday, phonenumber)
                                values(@firstname, @lastname, @username, @password, @birthday, @phonenumber);";
            cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@lastname", txtLastName.Text);
            cmd.Parameters.AddWithValue("@username", txtUserName.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@birthday", dtpBirthday.Text);
            cmd.Parameters.AddWithValue("@phonenumber", txtPhoneNumber.Text);
            database.conn.Open();
            cmd.ExecuteNonQuery();
            database.conn.Close();
        }

        //send claim button method
        private void btnSendClaim_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = database.conn;
            cmd.CommandText = @"insert into claims (username, date, status, claim) 
                                values(@username, @date, @status, @claim);";
            cmd.Parameters.AddWithValue("@username", txtClaimUserName.Text);
            cmd.Parameters.AddWithValue("@date", dtpClaimDate.Text);
            cmd.Parameters.AddWithValue("@status", txtClaimStatus.Text);
            cmd.Parameters.AddWithValue("@claim", txtWriteClaim.Text);
            database.conn.Open();
            cmd.ExecuteNonQuery();
            database.conn.Close();

        }
    }
}
