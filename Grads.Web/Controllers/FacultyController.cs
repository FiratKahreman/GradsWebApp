using Grads.Web.Services;
using GradsApp.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace Grads.Web.Controllers
{
    public class FacultyController : Controller
    {
        private readonly FacultyAPIService _facultyAPIService;

        public FacultyController(FacultyAPIService facultyAPIService)
        {
            _facultyAPIService = facultyAPIService;
        }

        public IActionResult Index()
        {            
            return View();
        }
    }
}
