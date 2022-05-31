using AutoMapper;
using GradsApp.Core.DTOs;
using GradsApp.Core.Models;
using GradsApp.Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GradsApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserProfileService _userProfileService;
        private readonly IMapper _mapper;

        public LoginController(IMapper mapper, IUserProfileService userProfileService)
        {
            _mapper = mapper;
            _userProfileService = userProfileService;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            //var login = _mapper.Map<UserProfile>(loginDTO);
            var response = await _userProfileService.Login(loginDTO);
            if (response == null)
            {
                return BadRequest("Kullanıcı Adı veya Parola Hatalı");
            }
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
