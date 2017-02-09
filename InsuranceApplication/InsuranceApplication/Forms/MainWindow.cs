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
using System.Xml;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace InsuranceApplication {
    public partial class formFormDemo : Form {
        public formFormDemo() {
            InitializeComponent();
        }

        public string firstname = null;
        public string lastname = null;
        public string username = null;
        public string password = null;
        public int rank = 0;
        public string creation = null;
        public int claims = 0;
        public int id = 0;

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void formFormDemo_Load(object sender, EventArgs e) {

        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            firstname = txtFirstName.Text;
            lastname = txtLastName.Text;
            username = txtUserName.Text;
            password = txtPassword.Text;
            rank = int.Parse(txtRank.Text);
            creation = txtCreation.Text;
            claims = int.Parse(txtClaims.Text);
            id = int.Parse(txtID.Text);
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
            libsql database = new libsql();
            database.ModifyProfile(xmldoc);
        }
    }
}
