using Grads.Web.Services;
using GradsApp.Core.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;

namespace Grads.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginAPIService _loginAPIService;
        private readonly IHttpContextAccessor _contextAccessor;
        public LoginController(LoginAPIService loginAPIService, IHttpContextAccessor contextAccessor)
        {
            _loginAPIService = loginAPIService;
            _contextAccessor = contextAccessor;
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
            HttpContext httpContext = _contextAccessor.HttpContext;
            var response = await _loginAPIService.UserIsValid(loginDto);
            if (response == null)
                return RedirectToAction("Index", "Login");
            else 
            {
                httpContext.Session.SetString("name", response.FirstName);
                httpContext.Session.SetString("surname", response.LastName);
                httpContext.Session.SetInt32("loginId", response.Id);
                httpContext.Session.SetString("mail", response.Mail);
                httpContext.Session.SetString("isGrad", response.IsGrad.ToString());
                return RedirectToAction("Index", "Social");
            }
                
        }

        public async Task<IActionResult> SignUpForm()
        {
            return View();
        }
        public async Task<IActionResult> SignUp(SignUpDTO signUpDto)
        {
            var response = await _loginAPIService.SignUp(signUpDto);
            return RedirectToAction("Index", "Login");            
        }
    }
}
