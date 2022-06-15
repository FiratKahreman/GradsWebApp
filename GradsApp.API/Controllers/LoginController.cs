using GradsApp.Core.DTOs;
using GradsApp.Core.Models;
using GradsApp.Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GradsApp.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserProfileService _userProfileService;

        public LoginController(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpDTO signUpDTO)
        {
            var response = await _userProfileService.SignUp(signUpDTO);
            return Ok(response.Id);
        }

        [HttpPost] 
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            //var login = _mapper.Map<UserProfile>(loginDTO);
            var response = await _userProfileService.Login(loginDTO);
            
            return Ok(response);
        }
        //[HttpPost]
        //public async Task<IActionResult> SignUp()
        //{
        //    return Ok();
        //}
        //[HttpPost]
        //public async Task<IActionResult> ForgetPassword()
        //{
        //    return Ok();
        //}
    }
}
