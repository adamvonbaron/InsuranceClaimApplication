/* adam 2017-02-01 Message.cs */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApplication.Classes {
    [Serializable]
    class Message {
        public string to {
            get;
            set;
        }

        public string from {
            get;
            set;
        }

        public string date {
            get;
            set;
        }

        public string subject {
            get;
            set;
        }

        public string message {
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
