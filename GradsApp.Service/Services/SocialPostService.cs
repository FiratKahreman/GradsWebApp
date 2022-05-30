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

        public Task CreatePost(SocialPost post)
        {
            return _socialPostRepository.CreateAsync(post);
        }

        public async Task<List<SocialPost>> GetAllPosts()
        {
            return await _socialPostRepository.GetAllAsync();
        }
    }
}
