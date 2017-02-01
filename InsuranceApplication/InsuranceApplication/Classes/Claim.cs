/* adam 2017-02-01 Claim.cs */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApplication.Classes {
    class Claim {
        public string date {
            get;
            set;
        }

        public string username {
            get;
            set;
        }

        public string claim {
            get;
            set;
        }

        /* key */
        public long id {
            get;
            set;
        }
    }
}
