using GradsApp.Core.DTOs;
using GradsApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Service.IServices
{
    public interface ISocialPostService
    {
        public Task<List<SocialPostDTO>> GetAllPosts();
        public Task<SocialPost> CreatePost(SocialPost post);
        public Task<int> AddLike(int id);
    }
}
