/* adam 2017-02-01 User.cs */
using System;
using System.Data;
using System.Windows.Forms;

namespace InsuranceApplication.Classes
{
    public enum UserType
    {
        /* 1 */ Admin = 1,
        /* 2 */ FinanceManager,
        /* 3 */ ClientManager,
        /* 4 */ Client,
        /* 5 */ Undefined
    }

    public struct UserData
    {
        public string FirstName;
        public string LastName;
        public string UserName;
        public string Password;
        public string Birthday;
        public string Phonenumber;
        public UserType Type;
    }

    public abstract class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Phonenumber { get; set; }
        public UserType Type { get; set; }

        public User(string username, string password)
        {
            UserName = username;
            Password = password;
        }

        public User(UserData userdata)
        {
            FirstName = userdata.FirstName;
            LastName = userdata.LastName;
            Birthday = userdata.Birthday;
            UserName = userdata.UserName;
            Password = userdata.Password;
            Type = userdata.Type;
        }

        public static UserType Login(string username, string password)
        {
            UserType type = UserType.Undefined;
            try
            {
                libsql.ValidateUser(username, password);
                type = (UserType)libsql.GetRank(username);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return type;
        }

        public static DataTable GetMessages(string username)
        {
            return libsql.GetInboxMessages(username);
        }

        public static bool SendMessage(Message message)
        {
            return libsql.SendMessage(message);
        }

        public static UserData GetUserData(string username)
        {
            return libsql.GetUserData(username);
        }

        public UserData GetUserData()
        {
            return libsql.GetUserData(UserName);
        }

        public static UserData NullUserData = new UserData
        {
            FirstName = "",
            LastName = "",
            UserName = "",
            Password = "",
            Birthday = "",
            Phonenumber = "",
            Type = UserType.Undefined
        };

        public override string ToString()
        {
            return String.Format(@"First Name: {0}\nLast Name: {1}\nUsername: {2}\nPassword: {3}\n
                           Birthday: {4}\nPhone Number: {5}", this.FirstName, this.LastName,
                                   this.UserName, this.Password, this.Birthday, this.Phonenumber);
        }
    }
}
