using System.Data;
using InsuranceApplication.Classes;
namespace InsuranceApplication.Interfaces
{
    interface Backend
    {
        bool RegisterUser(User user);
        bool UpdateUser(User user);
        bool SendClaim(Claim claim);
        bool SendMessage(Message message);
        DataTable GetInboxMessages(string username);
        bool ValidateUser(string username, string password);
        UserType GetRank(string username);
        string GetFirstName(string username);
        string GetLastName(string username);
        bool UpdateRank(string username, UserType rank);
        bool UpdatePassword(string username, string password);
        UserData GetUserData(string username);
        bool DeleteUser(string username);
    }
}
