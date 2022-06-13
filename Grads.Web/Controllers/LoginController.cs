using Microsoft.AspNetCore.Mvc;

namespace Grads.Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
