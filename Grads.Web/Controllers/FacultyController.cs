using Grads.Web.Services;
using GradsApp.Service.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
            var faculties = _facultyAPIService.GetFaculties();
            return View(faculties);
        }
    }
}
