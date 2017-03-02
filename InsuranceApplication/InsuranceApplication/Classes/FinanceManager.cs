using InsuranceApplication.Classes;

namespace InsuranceApplication.Classes
{
    public class FinanceManager : User
    {
        public FinanceManager(string username, string password)
                              : base(username, password)
        {
            UserData userdata = libsql.GetUserData(UserName);
            FirstName = userdata.FirstName;
            LastName = userdata.LastName;
            Birthday = userdata.Birthday;
            Phonenumber = userdata.Phonenumber;
            Type = userdata.Type;
        }

        public FinanceManager(UserData userdata) : base(userdata) { }
    }
}
