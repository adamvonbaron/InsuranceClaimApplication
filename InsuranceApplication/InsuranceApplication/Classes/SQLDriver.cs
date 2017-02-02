/* adam 2017-01-30 SQLDriver.cs */
using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace InsuranceApplication.Classes {
    class SQLDriver {
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
        private XmlDocument GetData(string table, string username) {
            string query = "select * from @table where username = @username";
            string xmlstring = null;
            XmlDocument xmldata = new XmlDocument();
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
                xmldata.LoadXml(xmlstring);
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
        private XmlDocument GetMessages(string username) {
            return GetData("messages", username);
        }

        //<summary>
        //get claims for user
        //</summary>
        private XmlDocument GetClaims(string username) {
            return GetData("claims", username);
        }

        private XmlDocument GetUser(string username) {
            return GetData("users", username);
        }

        //<summary>
        //modify profile
        //</summary>
        private XmlDocument ModifyProfile(XmlDocument xmldoc) {
            SqlCommand cmd = null;
            XmlReader xmlread = null;
            XmlDocument xmldata = null;
            string statement = @"update users
                                set firstname = @firstname,
                                    lastname = @lastname,
                                    username = @username,
                                    password = @password,
                                    rank = @rank,
                                    creation = @creation,
                                    claims = @claims
                                    where username = @username for xml auto, xmldata;";
            try {
                cmd = new SqlCommand(statement, conn);
                cmd.Parameters.AddWithValue("@firstname", xmldoc.GetElementById("firstname").ToString());
                cmd.Parameters.AddWithValue("@lastname", xmldoc.GetElementById("lastname").ToString());
                cmd.Parameters.AddWithValue("@username", xmldoc.GetElementById("username").ToString());
                cmd.Parameters.AddWithValue("@password", xmldoc.GetElementById("password").ToString());
                cmd.Parameters.AddWithValue("@rank", int.Parse(xmldoc.GetElementById("rank").ToString()));
                cmd.Parameters.AddWithValue("@creation", xmldoc.GetElementById("creation").ToString());
                cmd.Parameters.AddWithValue("@claims", int.Parse(xmldoc.GetElementById("claims").ToString()));
                xmlread = cmd.ExecuteXmlReader();
                xmldata.Load(xmlread);
            } catch (SqlException ex) {
                MessageBox.Show(ex.ToString(), "SQL Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (XmlException ex) {
                MessageBox.Show(ex.ToString(), "XML Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                xmlread.Close();
            }
            return xmldata;
        }

        //<summary>
        //send claim to database
        //</summary>
        private XmlDocument SendClaim(XmlDocument xmldoc) {
            SqlCommand cmd = null;
            XmlReader xmlread = null;
            XmlDocument xmldata = null;
            string statement = @"insert into claims (date, username, claim)
                                 values (@date, @username, @claim)
                                 where username = @username for xml auto, xmldata;";
            try {
                cmd = new SqlCommand(statement, conn);
                cmd.Parameters.AddWithValue("@date", xmldoc.GetElementById("date").ToString());
                cmd.Parameters.AddWithValue("@username", xmldoc.GetElementById("username").ToString());
                cmd.Parameters.AddWithValue("@claim", xmldoc.GetElementById("claim").ToString());
                xmlread = cmd.ExecuteXmlReader();
                xmldata.Load(xmlread);
            } catch (SqlException ex) {
                MessageBox.Show(ex.ToString(), "SQL Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (XmlException ex) {
                MessageBox.Show(ex.ToString(), "XML Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                xmlread.Close();
            }
            return xmldata;
        }

        //<summary>
        //send message to database
        //</summary>
        private XmlDocument SendMessage(XmlDocument xmldoc) {
            SqlCommand cmd = null;
            XmlReader xmlread = null;
            XmlDocument xmldata = null;
            string statement = @"insert into messages 
                                 (to, from, date, subject, message)
                                 values (@to, @from, @date, @subject, @message)
                                 where username = @to for xml auto, xmldata;";
            try {
                cmd = new SqlCommand(statement, conn);
                cmd.Parameters.AddWithValue("@to", xmldoc.GetElementById("to").ToString());
                cmd.Parameters.AddWithValue("@from", xmldoc.GetElementById("from").ToString());
                cmd.Parameters.AddWithValue("@date", xmldoc.GetElementById("date").ToString());
                cmd.Parameters.AddWithValue("@subject", xmldoc.GetElementById("subject").ToString());
                cmd.Parameters.AddWithValue("@message", xmldoc.GetElementById("message").ToString());
                xmlread = cmd.ExecuteXmlReader();
                xmldata.Load(xmlread);
            } catch (SqlException ex) {
                MessageBox.Show(ex.ToString(), "SQL Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (XmlException ex) {
                MessageBox.Show(ex.ToString(), "XML Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                xmlread.Close();
            }
            return xmldata;
        }
    }
}
