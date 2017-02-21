using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApplication.Classes
{
    class Client
    {
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Rank { get; set; }

        //constructor
        public Client(string firstname, string lastname, string username,
            string password, int rank)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.UserName = username;
            this.Password = password;
            this.Rank = rank;
        }

        //methods
        public void ApplyClaim()
        {

        }
        public void ViewMessages()
        {

        }
        public void ViewStatus()
        {

        }
        public void Upload()
        {

        }
        public void EditProfile()
        {

        } 
    }
}
