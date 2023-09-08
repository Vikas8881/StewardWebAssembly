using Microsoft.EntityFrameworkCore;
using StewardAPI.Data;
using Model;
using System.Security.Claims;
using StewardAPI.Models;

namespace StewardAPI.Repository.User
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AppDbContext _AppDbContext;

        public UserService(IHttpContextAccessor httpContextAccessor, AppDbContext AppDbContext)
        {
            _httpContextAccessor = httpContextAccessor;
            _AppDbContext = AppDbContext;
        }

        public async Task<ApplicationUser> GetUserByEmail(string email)
        {
            return await _AppDbContext.Users.FirstOrDefaultAsync(u => u.Email.Equals(email));
        }

        public string GetUserEmail()
        {
            var result = string.Empty;

            if (_httpContextAccessor.HttpContext != null)
            {
                result = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Email);
            }
            return result;
        }

        public string GetUserID()
        {
            var result = string.Empty;

            if (_httpContextAccessor.HttpContext != null)
            {
                result = _httpContextAccessor.HttpContext.User.FindFirstValue(CustomClaims.HospitalID);
            }
            return result;
        }

        public string GetUserName()
        {
            var result = string.Empty;

            if (_httpContextAccessor.HttpContext != null)
            {
                result = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            }
            return result;
        }
    }
}
