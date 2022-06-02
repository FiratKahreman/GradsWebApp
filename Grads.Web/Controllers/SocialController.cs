using Grads.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Grads.Web.Controllers
{
    public class SocialController : Controller
    {
        private readonly SocialAPIService _socialAPIService;

        public SocialController(SocialAPIService socialAPIService)
        {
            _socialAPIService = socialAPIService;
        }

        public async Task<IActionResult> Index()
        {
            var posts = await _socialAPIService.GetPosts();
            return View(posts);
        }
    }
}
