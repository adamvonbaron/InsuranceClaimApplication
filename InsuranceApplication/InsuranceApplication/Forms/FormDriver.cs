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
            string to, from, date, subject, message = string.Empty;
            to = txtTo.Text;
            from = txtFrom.Text;
            date = txtDate.Text;
            subject = txtSubject.Text;
            message = txtMessage.Text;
            XDocument xmldoc = new XDocument();
            XElement xml = new XElement("user",
                           new XElement("to", to),
                           new XElement("from", from),
                           new XElement("date", date),
                           new XElement("subject", subject),
                           new XElement("message", message));
            xmldoc.Add(xml);
            xmldoc.Save("H:\\message_demo.xml");
            int rowsaffected = database.SendMessage(xmldoc);
            MessageBox.Show("Rows affected: " + rowsaffected, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
