using GradsApp.Core.Models;
using GradsApp.Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GradsApp.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SocialController : ControllerBase
    {
        private readonly ISocialPostService _socialPostService;
        private readonly ISocialCommentService _socialCommentService;

        public SocialController(ISocialCommentService socialCommentService, ISocialPostService socialPostService)
        {
            _socialCommentService = socialCommentService;
            _socialPostService = socialPostService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPosts()
        {
            var list = await _socialPostService.GetAllPosts();
            return Ok(list);
        }

        [HttpGet]
        public async Task<IActionResult> GetComments()
        {
            var list = await _socialCommentService.GetAll();
            return Ok(list);
        }

        [HttpPost]
        public async Task<IActionResult> NewPost(SocialPost socialPost)
        {
            await _socialPostService.CreatePost(socialPost);
            return Ok();
        }
    }
}
