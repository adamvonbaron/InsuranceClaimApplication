using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsuranceApplication.Forms;

namespace InsuranceApplication.ClassesRefine
{
    class Admin : User
    {
        Classes.libsql database = new Classes.libsql();
       
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Rank { get; set; }
        public string Birthday { get; set; }
        public string Phonenumber { get; set; }

        //constructor
        public Admin(string firstname, string lastname, string username, string password, int rank, string birthday, string phonenumber)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.UserName = username;
            this.Password = password;
            this.Rank = rank;
            this.Birthday = birthday;
            this.Phonenumber = phonenumber;
        }

        //methods
        public void UpdateUser(string firstname, string lastname, string username, string password, int rank, string birthday, string phonenumber)
        {
             
        }

        public void DeleteUser(string username)
        {
            DeleteUser du = new DeleteUser(this);

            //if(username != null)
            //{
            //    DeleteUser(username);
            //}
            //else
            //{
            //    //error message
            //}
        }
       
    }
}
