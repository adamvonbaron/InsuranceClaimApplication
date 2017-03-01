using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsuranceApplication.Forms;
using InsuranceApplication.Classes;

namespace InsuranceApplication.Classes
{
    public class Admin : User
    {
        public Admin(string username, string password) : base(username, password)
        {
            UserData userdata = libsql.GetUserData(UserName);
            FirstName = userdata.FirstName;
            LastName = userdata.LastName;
            Birthday = userdata.Birthday;
            Phonenumber = userdata.Phonenumber;
            Type = userdata.Type;
        }

        //methods
        public void UpdateUser(User user)
        {
             
        }

        public bool DeleteUser(string username)
        {
            return libsql.DeleteUser(username);
        }

        public static bool RegisterUser(Client client)
        {
            return libsql.RegisterUser(client);
        }
       
    }
}
