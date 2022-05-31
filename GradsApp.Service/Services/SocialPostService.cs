using GradsApp.Core.DTOs;
using GradsApp.Core.Models;
using GradsApp.Repository.IRepositories;
using GradsApp.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Service.Services
{
    public class SocialPostService : ISocialPostService
    {
        private readonly ISocialPostRepository _socialPostRepository;

        public SocialPostService(ISocialPostRepository socialPostRepository)
        {
            _socialPostRepository = socialPostRepository;
        }

        public async Task CreatePost(SocialPost post)
        {
            var newPost = post;
            await _socialPostRepository.CreateAsync(newPost);
        }

        public async Task<List<SocialPostDTO>> GetAllPosts()
        {
            return await _socialPostRepository.GetAllPosts();
        }
    }
}
