using Grads.Web.Services;
using GradsApp.Core.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Grads.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginAPIService _loginAPIService;

        public LoginController(LoginAPIService loginAPIService)
        {
            _loginAPIService = loginAPIService;
        }

        public async Task<IActionResult> Index()
        {
            

            return View();        
            
            
            
            //if (userResponse != null)
            //{
            //    string displayName = userResponse.FirstName + userResponse.LastName;
            //    var claims = new[] {
            //            new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
            //            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            //            new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
            //            new Claim("UserId", userResponse.Id.ToString()),
            //            new Claim("DisplayName", userResponse.FirstName.ToString()),
            //            new Claim("UserName", displayName.ToString()),
            //            new Claim("Email", userResponse.Mail.ToString())
            //        };

            //    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            //    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            //    var token = new JwtSecurityToken(
            //        _configuration["Jwt:Issuer"],
            //        _configuration["Jwt:Audience"],
            //        claims,
            //        expires: DateTime.UtcNow.AddMinutes(2),
            //        signingCredentials: signIn);
            //    return new JwtSecurityTokenHandler().WriteToken(token);
            //}
            //else
            //{
            //    return null;
            //}
            //return View();
        }

        public async Task<IActionResult> LoginPost(LoginDTO loginDto)
        {
            var response = await _loginAPIService.UserIsValid(loginDto);
            if (response == false)
                return RedirectToAction("Index", "Login");
            else 
                return RedirectToAction("Index", "Social");
        }
    }
}
