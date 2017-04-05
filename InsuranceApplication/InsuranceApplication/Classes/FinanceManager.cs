using InsuranceApplication.Classes;

namespace InsuranceApplication.Classes
{
    public class FinanceManager : User
    {
        public FinanceManager(string username, string password)
                              : base(username, password)
        {
            UserData userdata = SqlManager.GetUserData(UserName);
            FirstName = userdata.FirstName;
            LastName = userdata.LastName;
            Birthday = userdata.Birthday;
            Phonenumber = userdata.Phonenumber;
            Type = userdata.Type;
        }

        public FinanceManager(UserData userdata) : base(userdata) { }

        //methods
        public void ViewProfile()
        {

        }

        public void ViewMessages()
        {

        }

        public void EstimateAmount()
        {

        }

    }
}
