using Grads.Web.Services;
using GradsApp.Core.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Web.Providers.Entities;

namespace Grads.Web.Controllers
{
    public class SocialController : Controller
    {
        private readonly SocialAPIService _socialAPIService;
        private readonly IHttpContextAccessor _contextAccessor;

        public SocialController(SocialAPIService socialAPIService, IHttpContextAccessor contextAccessor)
        {
            _socialAPIService = socialAPIService;
            _contextAccessor = contextAccessor;
        }

        public async Task<IActionResult> Index()
        {
            var posts = await _socialAPIService.GetPosts();
            return View(posts);
        }

        public async Task<IActionResult> CreatePost(string title, string message,int loginId)
        {
            var postText = message;
            var postTitle = title;
            
            var newPostDto = new CreatePostDTO() { Likes = 0 , PostText = postText, PostTitle = postTitle, PostProfileId = loginId };
            _socialAPIService.NewPost(newPostDto);
            return RedirectToAction("Index", "Social");
        }

        public async Task<IActionResult> NewComment(int loginId, string comment, int postId)
        {
            var newCommentDto = new CreateCommentDTO() { CommentProfileId = loginId, PostId = postId, CommentText = comment };
            _socialAPIService.NewComment(newCommentDto);
            return RedirectToAction("Index", "Social");
        }

        public async Task<IActionResult> Like(int id)
        {
            var response = await _socialAPIService.AddLike(id);
            return RedirectToAction("Index", "Social");
        }

    }
}
