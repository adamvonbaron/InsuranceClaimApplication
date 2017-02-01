/* adam 2017-01-30 SQLDriver.cs */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Data.SqlTypes;

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

        //<summary>
        //modify profile
        //</summary>
        private int ModifyProfile(XmlDocument xmldoc) {
            SqlCommand cmd;
            string statement = @"update users
                                set firstname = @firstname,
                                    lastname = @lastname,
                                    username = @username,
                                    password = @password,
                                    rank = @rank,
                                    creation = @creation,
                                    claims = @claims";
            try {
                cmd = new SqlCommand(statement, conn);
                cmd.Parameters.AddWithValue("@firstname", xmldoc.GetElementById("firstname").ToString());
                cmd.Parameters.AddWithValue("@lastname", xmldoc.GetElementById("lastname").ToString());
                cmd.Parameters.AddWithValue("@username", xmldoc.GetElementById("username").ToString());
                cmd.Parameters.AddWithValue("@password", xmldoc.GetElementById("password").ToString());
                cmd.Parameters.AddWithValue("@rank", int.Parse(xmldoc.GetElementById("rank").ToString()));
                cmd.Parameters.AddWithValue("@creation", xmldoc.GetElementById("creation").ToString());
                cmd.Parameters.AddWithValue("@claims", int.Parse(xmldoc.GetElementById("claims").ToString()));
                int affected = cmd.ExecuteNonQuery();
                return affected;
            } catch (SqlException ex) {
                return 0;
            }
        }

        //<summary>
        //send claim to database
        //</summary>
        private int SendClaim(XmlDocument xmldoc) {
            try {
            
            } catch (SqlException ex) {
                return 0;
            }
        }

        //<summary>
        //send message to database
        //</summary>
        private int SendMessage(XmlDocument xmldoc) {

        }

        private int DeleteUser(XmlDocument xmldoc) {

        }

        private int AddUser(XmlDocument xmldoc) {

        }
    }
}
