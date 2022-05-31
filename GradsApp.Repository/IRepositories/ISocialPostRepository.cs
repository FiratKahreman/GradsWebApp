using GradsApp.Core.DTOs;
using GradsApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Repository.IRepositories
{
    public interface ISocialPostRepository : IGenericRepository<SocialPost>
    {
        public Task<List<SocialPostDTO>> GetAllPosts();
    }
}
