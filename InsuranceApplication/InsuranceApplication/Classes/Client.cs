using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsuranceApplication.Forms;

namespace InsuranceApplication.Classes
{
    public class Client : User
    {
        public Client(string username, string password) : base(username, password)
        {
            UserData userdata = libsql.GetUserData(UserName);
            FirstName = userdata.FirstName;
            LastName = userdata.LastName;
            Birthday = userdata.Birthday;
            Phonenumber = userdata.Phonenumber;
            Type = userdata.Type;
        }

        public void ViewProfile()
        {

        }

        public void EditProfile()
        {
            EditUserProfile eup = new EditUserProfile(this);

        }

        public void ApplyForClaim()
        {

        }

        public void ViewMessages()
        {

        }
    }    
}
