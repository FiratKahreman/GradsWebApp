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
        public Task<List<SocialPost>> GetAllPosts();
        public Task CreatePost(SocialPost post);
    }
}
