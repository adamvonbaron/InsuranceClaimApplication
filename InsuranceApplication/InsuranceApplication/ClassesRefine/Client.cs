using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsuranceApplication.Forms;

namespace InsuranceApplication.ClassesRefine
{
    public class Client : User
    {
        public Client(string firstname, string lastname, string username, string password,
                      string birthday, string phonenumber, int rank) :
               base(firstname, lastname, username, password,
                    birthday, phonenumber, rank)
        {

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
