using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Model;

using StewardAPI.Repository.User;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using StewardAPI.Models;
using Model.DTO;

namespace StewardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;
        public static ApplicationUser user = new ApplicationUser();
        public AuthController(IMapper mapper, UserManager<ApplicationUser> userManager, IConfiguration configuration, IUserService userService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _configuration = configuration;
            _userService = userService;
        }
        [HttpGet]
        public ActionResult<string> GetMyName()
        {
            var username = _userService.GetUserID();
            return Ok(username);
            //var userName = User?.Identity?.Name;
            //var userID = HttpContext.User.FindFirstValue(CustomClaims.Uid);
            //var roleClaims = User?.FindAll(ClaimTypes.Role);
            //var roles = roleClaims?.Select(c => c.Value).ToList();
            //var roles2 = User?.Claims
            //    .Where(c => c.Type == ClaimTypes.Role)
            //    .Select(c => c.Value)
            //    .ToList();
            //return Ok(new {userName, userID});
        }

        [HttpPost]
        [Route("register")]
        public async Task<ActionResult<ServiceResponse<string>>> Register(RegistrationDTO userDto)
        {
            var user = _mapper.Map<ApplicationUser>(userDto);
            user.UserName = userDto.Email;
            var result = await _userManager.CreateAsync(user, userDto.Password);
            if (result.Succeeded == false)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            await _userManager.AddToRoleAsync(user, "User");
            return Accepted();
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(Model.LoginUserDto request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
            {
                return NotFound();
            }
            var passwordValid = await _userManager.CheckPasswordAsync(user, request.Password);

            if (passwordValid == false)
            {
                return Ok("Wrong Password");
            }
            string tokenString = await GenerateToken(user);
            var response = new ServiceResponse<string>()
            {
                Data = tokenString,
            };
            return Ok(response);

        }

        private async Task<string> GenerateToken(ApplicationUser user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var roles = await _userManager.GetRolesAsync(user);
            var roleClaims = roles.Select(q => new Claim(ClaimTypes.Role, q)).ToList();
            var userClaims = await _userManager.GetClaimsAsync(user);
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub,user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email,user.Email),
                new Claim(JwtRegisteredClaimNames.Sid,user.Id.ToString()),

                new Claim(ClaimTypes.Name,user.FirstName),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(CustomClaims.Uid,user.Id.ToString()),
                new Claim(CustomClaims.HospitalID,user.HospitalID.ToString()),
            }
            .Union(roleClaims)
            .Union(userClaims);

            var token = new JwtSecurityToken(
                issuer: _configuration["JwtSettings:Issuer"],
                audience: _configuration["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddDays(Convert.ToInt32(_configuration["JwtSettings:Duration"])),
                signingCredentials: credentials
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
