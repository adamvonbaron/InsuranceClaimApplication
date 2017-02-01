/* adam 2017-01-30 SQLDriver.cs */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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

        /* SQL return structure */
        public struct SqlRecv {
            public bool data;
            public DataTable datatable;
        }

        /* methods */
        //<summary>
        //modify profile
        //TODO: figure out if i should use SqlCommand or SqlDataAdapter
        //</summary>
        private int ModifyProfile(string statement, long userid) {
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
        private int SendClaim(string statement, long userid) {
            try {
            
            } catch (SqlException ex) {
                return 0;
            }
        }

        private int SendMessage(string statment, long )
    }
}
