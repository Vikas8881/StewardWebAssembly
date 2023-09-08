using Model;
using StewardAPI.Models;

namespace StewardAPI.Repository.User
{
    public interface IUserService
    {
        string GetUserID();
        string GetUserEmail();
        string GetUserName();
        Task<ApplicationUser> GetUserByEmail(string email);
    }
}
