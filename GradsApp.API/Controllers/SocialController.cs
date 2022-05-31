using AutoMapper;
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
        private readonly IMapper _mapper;

        public SocialController(ISocialCommentService socialCommentService, ISocialPostService socialPostService, IMapper mapper)
        {
            _socialCommentService = socialCommentService;
            _socialPostService = socialPostService;
            _mapper = mapper;
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

        //[HttpPost]
        //public async Task<IActionResult> NewPost(SocialPost socialPost)
        //{
        //    //var newPost = _mapper.Map<SocialPost>(socialPost);
        //    //await _socialPostService.CreatePost(newPost);
        //    //return Ok(newPost);
        //}
    }
}
