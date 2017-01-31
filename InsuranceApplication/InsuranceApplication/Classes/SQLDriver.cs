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
            using (var conn = new SqlConnection(
                @"Server=tcp:insuranceclaim.database.windows.net,1433;
                Initial Catalog=InsuranceClaim; 
                Persist Security Info=False;
                User ID=charlesroot;
                Password=Ieamainsuranceclaim123;
                MultipleActiveResultSets=False;
                Encrypt=True;
                TrustServerCertificate=False;
                Connection Timeout=30;")) {
                conn.Open();
            }
        }
    }
}
