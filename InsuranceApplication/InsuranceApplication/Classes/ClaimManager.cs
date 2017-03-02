using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsuranceApplication.Classes;

namespace InsuranceApplication.Classes
{
    public class ClaimManager : User
    {
        public ClaimManager(string username, string password)
                            : base(username, password)
        {
            UserData userdata = libsql.GetUserData(UserName);
            FirstName = userdata.FirstName;
            LastName = userdata.LastName;
            Birthday = userdata.Birthday;
            Phonenumber = userdata.Phonenumber;
            Type = userdata.Type;
        }

        public ClaimManager(UserData userdata) : base(userdata) { }

        //methods
        public static DataTable ViewMessages(string username)
        {
            return libsql.GetInboxMessages(username)
        }
    }
}
