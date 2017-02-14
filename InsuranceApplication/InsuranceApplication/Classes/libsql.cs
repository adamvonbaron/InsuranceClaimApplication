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
            string query = "select * from " + table.ToString() + " where username = " + username.ToString() + ";";
            DataTable dtData = new DataTable();
            SqlDataAdapter sdaData = new SqlDataAdapter(query, conn);
            BindingSource bsData = new BindingSource();
            sdaData.Fill(dtData);
            bsData.DataSource = dtData;
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
            int rowsaffected = -1;
            SqlDataAdapter sda;
            try {
                SqlCommand cmd = new SqlCommand(@"update users set
                                              firstname = @firstname,
                                              lastname = @lastname,
                                              username = @username,
                                              password = @password,
                                              birthday = @birthday,
                                              phonenumber = @phonenumber
                                              where username = @oldusername;", conn);
                cmd.Parameters.Add("@firstname", SqlDbType.NVarChar, 50, xmldoc.Root.Element("firstname").Value);
                cmd.Parameters.Add("@lastname", SqlDbType.NVarChar, 50, xmldoc.Root.Element("lastname").Value);
                cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50, xmldoc.Root.Element("username").Value);
                cmd.Parameters.Add("@password", SqlDbType.NVarChar, -1, xmldoc.Root.Element("password").Value);
                cmd.Parameters.Add("@birthday", SqlDbType.DateTime, -1, xmldoc.Root.Element("birthday").Value);
                cmd.Parameters.Add("@phonenumber", SqlDbType.NVarChar, 50, xmldoc.Root.Element("phonenumber").Value);
                cmd.Parameters.Add("@oldusername", SqlDbType.NVarChar, 50, xmldoc.Root.Element("username").Value);
                sda = new SqlDataAdapter();
                sda.UpdateCommand = cmd;
                conn.Open();
                rowsaffected = sda.UpdateCommand.ExecuteNonQuery();
            } catch (SqlException ex) {
                MessageBox.Show(ex.ToString());
            } catch (NullReferenceException ex) {
                MessageBox.Show(ex.ToString());
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
            string statement = @"insert into claims (date, username, status, claim)
                                 values (@date, @username, @status, @claim);";
            try {
                cmd = new SqlCommand(statement, conn);
                cmd.Parameters.AddWithValue("@date", xmldoc.Root.Element("date").Value);
                cmd.Parameters.AddWithValue("@username", xmldoc.Root.Element("username").Value);
                cmd.Parameters.AddWithValue("@status", xmldoc.Root.Element("status").Value);
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

        public int InsertUser(XDocument xmldoc) {
            int rowsaffected = -1;
            SqlDataAdapter sda;
            try {
                SqlCommand cmd = new SqlCommand(@"insert into users
                                                  (firstname, lastname, username, password, birthday, phonenumber)
                                                  values
                                                  (@firstname, @lastname, @username, @password, @birthday @phonenumber);", conn);
                cmd.Parameters.Add("@firstname", SqlDbType.NVarChar).Value = xmldoc.Root.Element("firstname").Value;
                cmd.Parameters.Add("@lastname", SqlDbType.NVarChar).Value = xmldoc.Root.Element("lastname").Value;
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = xmldoc.Root.Element("username").Value;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = xmldoc.Root.Element("password").Value;
                cmd.Parameters.Add("@birthday", SqlDbType.NVarChar).Value = xmldoc.Root.Element("birthday").Value;
                cmd.Parameters.Add("@phonenumber", SqlDbType.NVarChar).Value = xmldoc.Root.Element("phonenumber").Value;
                sda = new SqlDataAdapter();
                sda.InsertCommand = cmd;
                conn.Open();
                rowsaffected = sda.InsertCommand.ExecuteNonQuery();
            } catch (SqlException ex) {
                MessageBox.Show(ex.ToString());
            } catch (NullReferenceException ex) {
                MessageBox.Show(ex.ToString());
            } finally {
                conn.Close();
            }
            return rowsaffected;
        }
    }
}
