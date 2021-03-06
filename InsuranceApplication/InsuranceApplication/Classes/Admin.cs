﻿namespace InsuranceApplication.Classes
{
    public class Admin : User
    {
        //constructor
        public Admin(string username, string password) : base(username, password)
        {
            UserData userdata = SqlManager.GetUserData(UserName);
            FirstName = userdata.FirstName;
            LastName = userdata.LastName;
            Birthday = userdata.Birthday;
            Phonenumber = userdata.Phonenumber;
            Type = userdata.Type;
        }

        public Admin(UserData userdata) : base(userdata) { }

        //methods

        //delete user from database
        public bool DeleteUser(string username)
        {
            return SqlManager.DeleteUser(username);
        }

        //change the type of the user
        public bool UpdatePermissions(string username, UserType type)
        {
            return SqlManager.UpdateRank(username, type);
        }

        //register a new user
        public static bool RegisterUser(Client client)
        {
            return SqlManager.RegisterUser(client);
        }
    }
}
