using Microsoft.AspNetCore.Mvc;

namespace Grads.Web.Controllers
{
    public class MapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
