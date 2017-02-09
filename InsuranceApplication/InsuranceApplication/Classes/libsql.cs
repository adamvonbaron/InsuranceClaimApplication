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
        private XDocument GetData(string table, string username) {
            string query = "select * from @table where username = @username";
            string xmlstring = null;
            XDocument xmldata = new XDocument();
            SqlDataAdapter da = null;
            try {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@table", table);
                da = new SqlDataAdapter(cmd);
                using (DataSet ds = new DataSet()) {
                    da.SelectCommand.Connection.Open();
                    da.Fill(ds);
                    if (ds != null && ds.Tables.Count > 0)
                        xmlstring = ds.GetXml();
                }
            } catch (SqlException ex) {
                MessageBox.Show(ex.ToString(), "Error", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                da.SelectCommand.Connection.Close();
            }
            return xmldata;
        }

        //<summary>
        //get messages for user
        //</summary>
        public XDocument GetMessages(string username) {
            return GetData("messages", username);
        }

        //<summary>
        //get claims for user
        //</summary>
        public XDocument GetClaims(string username) {
            return GetData("claims", username);
        }

        public XDocument GetUser(string username) {
            return GetData("users", username);
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
                                 values (@date, @username, @claim)
                                 where username = @username;";
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
                                 values (@to, @from, @date, @subject, @message)
                                 where username = @to;";
            try {
                cmd = new SqlCommand(statement, conn);
                cmd.Parameters.AddWithValue("@to", xmldoc.Root.Element("to").Value);
                cmd.Parameters.AddWithValue("@from", xmldoc.Root.Element("from").Value);
                cmd.Parameters.AddWithValue("@date", xmldoc.Root.Element("date").Value);
                cmd.Parameters.AddWithValue("@subject", xmldoc.Root.Element("subject").Value);
                cmd.Parameters.AddWithValue("@message", xmldoc.Root.Element("message").Value);
                rowsaffected = cmd.ExecuteNonQuery();
            } catch (SqlException ex) {
                MessageBox.Show(ex.ToString(), "SQL Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rowsaffected;
        }
    }
}
