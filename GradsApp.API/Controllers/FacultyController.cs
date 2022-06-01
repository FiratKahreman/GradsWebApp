using GradsApp.Service.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GradsApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacultyController : ControllerBase
    {
        private readonly IFacultyService _facultyService;

        public FacultyController(IFacultyService service)
        {
            _facultyService = service;
        }

        // GET: api/
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _facultyService.GetAll();
            var list = JsonConvert.SerializeObject(response);
            return Ok(list);
        }

       
    }
}
