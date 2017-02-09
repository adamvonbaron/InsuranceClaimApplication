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

        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            int rank = int.Parse(txtRank.Text);
            string creation = txtCreation.Text;
            int claims = int.Parse(txtClaims.Text);
            long id = int.Parse(txtID.Text);
            XDocument xmldoc = new XDocument();
            XElement xml = new XElement("user",
                           new XElement("firstname", firstname),
                           new XElement("lastname", lastname),
                           new XElement("username", username),
                           new XElement("password", password),
                           new XElement("rank", rank),
                           new XElement("creation", claims),
                           new XElement("claims", claims),
                           new XElement("id", id));
            xmldoc.Add(xml);
            xmldoc.Save("H:\\user_demo.xml");
            int rowsaffected = database.ModifyProfile(xmldoc);
            MessageBox.Show("Rows affected: " + rowsaffected, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSendMessage_Click(object sender, EventArgs e) {
            string to, from, date, subject, message = string.Empty;
            to = txtTo.Text;
            from = txtFrom.Text;
            date = txtDate.Text;
            subject = txtSubject.Text;
            message = txtMessage.Text;
            XDocument xmldoc = new XDocument();
            XElement xml = new XElement("userMessage",
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
    }
}
