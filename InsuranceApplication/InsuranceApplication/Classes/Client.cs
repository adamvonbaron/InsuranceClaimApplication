﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsuranceApplication.Forms;

namespace InsuranceApplication.Classes
{
    public class Client : User
    {
        //constructor
        public Client(string username, string password) : base(username, password)
        {
            UserData userdata = SqlManager.GetUserData(UserName);
            FirstName = userdata.FirstName;
            LastName = userdata.LastName;
            Birthday = userdata.Birthday;
            Phonenumber = userdata.Phonenumber;
            Type = userdata.Type;
        }

        public Client(UserData userdata) : base(userdata) { }

        //apply for new insurance claim
        public bool ApplyForClaim(Claim claim)
        {
            return SqlManager.SendClaim(claim);
        }
    }    
}
