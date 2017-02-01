/* adam 2017-02-01 User.cs */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApplication.Classes {
    [Serializable]
    class User {
        public string firstname {
            get;
            set;
        }

        public string lastname {
            get;
            set;
        }

        public string username {
            get;
            set;
        }

        public string password {
            get;
            set;
        }

        public int rank {
            get;
            set;
        }

        public string creation {
            get;
            set;
        }

        public int claims {
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
