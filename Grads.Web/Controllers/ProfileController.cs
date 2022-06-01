using Grads.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Grads.Web.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ProfileAPIService _profileAPIService;

        public ProfileController(ProfileAPIService profileAPIService)
        {
            _profileAPIService = profileAPIService;
        }

        public async Task<IActionResult> Index(int id)
        {
            var response = await _profileAPIService.GetProfile(id);
            
            return View(response);
        }
    }
}
