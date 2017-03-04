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

        public bool UpdatePermissions(string username, UserType type)
        {
            return libsql.UpdateRank(username, type);
        }

        public static bool RegisterUser(Client client)
        {
            return libsql.RegisterUser(client);
        }
    }
}
