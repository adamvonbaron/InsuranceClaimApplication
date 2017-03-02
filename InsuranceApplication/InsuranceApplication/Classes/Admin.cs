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

        public Admin(UserData userdata) : base(userdata) { }

        //methods
        public bool DeleteUser(string username)
        {
            return libsql.DeleteUser(username);
        }

        public bool UpdatePermissions(string username, int rank)
        {
            return libsql.UpdateRank(username, rank);
        }

        public static bool RegisterUser(Client client)
        {
            return libsql.RegisterUser(client);
        }

        public static bool UpdateUser(UserData userdata)
        {
            User user;
            switch(userdata.Type)
            {
                case UserType.Admin:
                    user = new Admin(userdata);
                    /* TODO: figure out why Phonenumber turns null here */
                    return libsql.UpdateUser(user);
                case UserType.FinanceManager:
                    //user = new FinanceManager(userdata);
                    //return libsql.UpdateUser(user);
                case UserType.ClientManager:
                    //user = new ClientManager(userdata);
                    //return libsql.UpdateUser(user);
                case UserType.Client:
                    user = new Client(userdata);
                    return libsql.UpdateUser(user);
            }
            return false;
        }
       
    }
}
