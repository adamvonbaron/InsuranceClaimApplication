/* adam 2017-01-30 SQLDriver.cs */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InsuranceApplication.Classes {
    class SQLDriver {
        public SQLDriver() {
            /* this connection string connects to a sql server
             * instance i have running on my azure acct so its ok */
            var conn = new SqlConnection(
                @"Server=tcp:insuranceclaim.database.windows.net,1433;
                Initial Catalog=InsuranceClaim; 
                Persist Security Info=False;
                User ID=charlesroot;
                Password=Ieamainsuranceclaim123;
                MultipleActiveResultSets=False;
                Encrypt=True;
                TrustServerCertificate=False;
                Connection Timeout=30;");
                conn.Open();
        }

        private void SendStatement(string statement) {
            SqlCommand cmd = new SqlCommand(statement, c);
        }
    }
}
