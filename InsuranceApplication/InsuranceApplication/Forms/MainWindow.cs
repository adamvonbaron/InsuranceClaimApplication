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
            // TODO: This line of code loads data into the 'insuranceClaimDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.insuranceClaimDataSet.users);

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
            SqlConnection conn = new SqlConnection(
            @"Server=tcp:insuranceclaim.database.windows.net,1433;
            Initial Catalog=InsuranceClaim;
            Persist Security Info=False;
            User ID=charlesroot;
            Password=Ieamainsuranceclaim123;
            MultipleActiveResultSets=False;
            Encrypt=True;
            TrustServerCertificate=False;
            Connection Timeout=30;");
            SqlCommand cmd = null;
            string statement = @"update users
                                set firstname = @firstname,
                                    lastname = @lastname,
                                    username = @username,
                                    password = @password,
                                    rank = @rank,
                                    creation = @creation,
                                    claims = @claims
                                    where username = @username;";
            try
            {
                cmd = new SqlCommand(statement, conn);
                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", username);
                cmd.Parameters.AddWithValue("@rank", rank);
                cmd.Parameters.AddWithValue("@creation", creation);
                cmd.Parameters.AddWithValue("@claims", claims);
                conn.Open();
                cmd.ExecuteNonQuery();
                dgvUsers.Refresh();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "SQL Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (XmlException ex)
            {
                MessageBox.Show(ex.ToString(), "XML Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
