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
        //get messages for user
        //</summary>
        private XmlDocument GetMessages(string username) {
            string query = "select * from messages where username = @username";
            string xmlstring = null;
            XmlDocument xmldata = new XmlDocument();
            SqlDataAdapter da = null;
            try {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                da = new SqlDataAdapter(cmd);
                using (DataSet ds = new DataSet()) {
                    da.SelectCommand.Connection.Open();
                    da.Fill(ds);
                    if (ds != null && ds.Tables.Count > 0)
                        xmlstring = ds.GetXml();
                }
                xmldata.LoadXml(xmlstring);
            } catch (SqlException ex) {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                da.SelectCommand.Connection.Close();
            }
            return xmldata;
        }
            
        //<summary>
        //modify profile
        //</summary>
        private int ModifyProfile(XmlDocument xmldoc) {
            SqlCommand cmd;
            try {
                cmd = new SqlCommand(statement, conn);

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
