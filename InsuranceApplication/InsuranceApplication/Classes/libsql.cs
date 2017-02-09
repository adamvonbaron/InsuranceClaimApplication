/* adam 2017-01-30 libsql.cs */
using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Windows.Forms;

namespace InsuranceApplication.Classes {
    class libsql {
        /* properties */
        private readonly SqlConnection _conn = new SqlConnection(
            @"Server=tcp:insuranceclaim.database.windows.net,1433;
            Initial Catalog=InsuranceClaim;
            Persist Security Info=False;
            User ID=charlesroot;
            Password=Ieamainsuranceclaim123;
            MultipleActiveResultSets=False;
            Encrypt=True;
            TrustServerCertificate=False;
            Connection Timeout=30;");

        public SqlConnection conn {
            get {
                return _conn;
            } private set {
                conn = value;
            }
        }

        /* methods */
        //<summary>
        //retrieve data from database
        //</summary>
        private void GetData(string table, string username) {
            try {
                string query = "select * from " + table + " where username = " + username + " for xml path('student')";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                var result = cmd.ExecuteNonQuery();
                MessageBox.Show(result.ToString());
            } catch (InvalidOperationException ex) {
                MessageBox.Show(ex.ToString());
            } catch (SqlException ex) {
                MessageBox.Show(ex.ToString());
            } finally {
                conn.Close();
            }
        }

        //<summary>
        //get messages for user
        //</summary>
        public void GetMessages(string username) {
            GetData("messages", username);
        }

        //<summary>
        //get claims for user
        //</summary>
        public void GetClaims(string username) {
            GetData("claims", username);
        }

        public void GetUser(string username) {
            GetData("users", username);
        }

        //<summary>
        //modify profile
        //</summary>
        public int ModifyProfile(XDocument xmldoc) {
            SqlCommand cmd = null;
            int rowsaffected = -1;
            string statement = @"update users
                                set firstname = @firstname,
                                    lastname = @lastname,
                                    username = @username,
                                    password = @password,
                                    rank = @rank,
                                    creation = @creation,
                                    claims = @claims
                                    where username = @username;";
            try {
                cmd = new SqlCommand(statement, conn);
                cmd.Parameters.AddWithValue("@firstname", xmldoc.Root.Element("firstname").Value);
                cmd.Parameters.AddWithValue("@lastname", xmldoc.Root.Element("lastname").Value);
                cmd.Parameters.AddWithValue("@username", xmldoc.Root.Element("username").Value);
                cmd.Parameters.AddWithValue("@password", xmldoc.Root.Element("password").Value);
                cmd.Parameters.AddWithValue("@rank", int.Parse(xmldoc.Root.Element("rank").Value));
                cmd.Parameters.AddWithValue("@creation", xmldoc.Root.Element("creation").Value);
                cmd.Parameters.AddWithValue("@claims", int.Parse(xmldoc.Root.Element("claims").Value));
                conn.Open();
                rowsaffected = cmd.ExecuteNonQuery();
            } catch (SqlException ex) {
                MessageBox.Show(ex.ToString(), "SQL Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (InvalidOperationException ex) {
                MessageBox.Show(ex.ToString(), "Null Reference Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                conn.Close();
            }
            return rowsaffected;
        }

        //<summary>
        //send claim to database
        //</summary>
        public int SendClaim(XDocument xmldoc) {
            SqlCommand cmd = null;
            int rowsaffected = -1;
            string statement = @"insert into claims (date, username, claim)
                                 values (@date, @username, @claim);";
            try {
                cmd = new SqlCommand(statement, conn);
                cmd.Parameters.AddWithValue("@date", xmldoc.Root.Element("date").Value);
                cmd.Parameters.AddWithValue("@username", xmldoc.Root.Element("username").Value);
                cmd.Parameters.AddWithValue("@claim", xmldoc.Root.Element("claim").Value);
                rowsaffected = cmd.ExecuteNonQuery();
            } catch (SqlException ex) {
                MessageBox.Show(ex.ToString(), "SQL Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rowsaffected;
        }

        //<summary>
        //send message to database
        //</summary>
        public int SendMessage(XDocument xmldoc) {
            SqlCommand cmd = null;
            int rowsaffected = -1;
            string statement = @"insert into messages 
                                 (to, from, date, subject, message)
                                 values (@to, @from, @date, @subject, @message);";
            try {
                cmd = new SqlCommand(statement, conn);
                cmd.Parameters.AddWithValue("@to", xmldoc.Root.Element("to").Value);
                cmd.Parameters.AddWithValue("@from", xmldoc.Root.Element("from").Value);
                cmd.Parameters.AddWithValue("@date", xmldoc.Root.Element("date").Value);
                cmd.Parameters.AddWithValue("@subject", xmldoc.Root.Element("subject").Value);
                cmd.Parameters.AddWithValue("@message", xmldoc.Root.Element("message").Value);
                conn.Open();
                rowsaffected = cmd.ExecuteNonQuery();
            } catch (SqlException ex) {
                MessageBox.Show(ex.ToString(), "SQL Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (InvalidOperationException ex) {
                MessageBox.Show(ex.ToString(), "Null Reference Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                conn.Close();
            }
            return rowsaffected;
        }
    }
}
