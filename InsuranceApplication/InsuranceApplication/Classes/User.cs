/* adam 2017-02-01 User.cs */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApplication.Classes {
    [Serializable]
    class User {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public int Rank { get; set; }

        //public string creation { get; set;}

        //public int claims { get; set;}

        /* key */
        //public long id { get; set;}

        //constructor
        public User(string firstname, string lastname, string username, string password,
            int rank)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.UserName = username;
            this.Password = password;
            this.Rank = rank;
        }

        //methods
        public void login(string username, string password)
        {

        }
    }
}
