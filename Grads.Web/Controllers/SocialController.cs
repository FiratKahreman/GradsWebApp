using Grads.Web.Services;
using GradsApp.Core.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Web.Providers.Entities;

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

        public async Task<IActionResult> NewPost(CreatePostDTO createPostDto)
        {
            _socialAPIService.NewPost(createPostDto);
            return Ok();
        }

        public async Task<JsonResult> NewComment(SocialCommentDTO socialCommentDto)
        {
            _socialAPIService.NewComment(socialCommentDto);
            return Json(new {success=true});
        }
    }
}
