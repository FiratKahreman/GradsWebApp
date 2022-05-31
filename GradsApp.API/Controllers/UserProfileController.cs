using GradsApp.Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GradsApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private readonly IUserProfileService _userProfileService;

        public UserProfileController(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProfile(int id)
        {
            var result =  await _userProfileService.GetProfileById(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }
    }
}
