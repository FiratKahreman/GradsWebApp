using AutoMapper;
using GradsApp.Core.DTOs;
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

        [HttpGet("{postId}")]
        public async Task<IActionResult> GetComments(int postId)
        {
            var list = await _socialCommentService.GetCommentByPost(postId);
            return Ok(list);
        }
        [HttpPost]
        public async Task<IActionResult> NewComment(SocialCommentDTO socialCommentDTO)
        {

            var comment = _mapper.Map<SocialComment>(socialCommentDTO);
            await _socialCommentService.CreateComment(comment);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> NewPost(CreatePostDTO createPostDto)
        {
            var post = _mapper.Map<SocialPost>(createPostDto);

            await _socialPostService.CreatePost(post);
            
            return Ok();
        }
    }
}
