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
            Phonenumber = userdata.Phonenumber;
            Type = userdata.Type;
        }

        public static UserType Login(string username, string password)
        {
            UserType type = UserType.Undefined;
            try
            {
                // nvm i fixed it
                if (!SqlManager.ValidateUser(username, password))
                    return UserType.Undefined;
                type = SqlManager.GetRank(username);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return type;
        }

        public static bool UpdateUser(UserData userdata)
        {
            User user;
            switch (userdata.Type)
            {
                case UserType.Admin:
                    user = new Admin(userdata);
                    return SqlManager.UpdateUser(user);
                case UserType.FinanceManager:
                user = new FinanceManager(userdata);
                return SqlManager.UpdateUser(user);
                case UserType.ClientManager:
                //user = new ClientManager(userdata);
                //return libsql.UpdateUser(user);
                case UserType.Client:
                    user = new Client(userdata);
                    return SqlManager.UpdateUser(user);
            }
            return false;
        }

        public static DataTable GetMessages(string username)
        {
            return SqlManager.GetInboxMessages(username);
        }

        public static DataTable GetClients()
        {
            return SqlManager.GetClientList();
        }

        public static DataTable GetManagers()
        {
            return SqlManager.GetManagement();
        }

        public static bool SendMessage(Message message)
        {
            return SqlManager.SendMessage(message);
        }

        public static UserData GetUserData(string username)
        {
            return SqlManager.GetUserData(username);
        }

        public UserData GetUserData()
        {
            return SqlManager.GetUserData(UserName);
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
