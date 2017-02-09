using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApplication.Classes
{
    class FinanceManger
    {

        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Rank { get; set; }

        //constructors
        public FinanceManger(string firstname, string lastname, string username,
            string password, int rank)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.UserName = username;
            this.Password = password;
            this.Rank = rank;
        } 

        //methods



    }
    }


