using GradsApp.Core.DTOs;
using GradsApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Repository.IRepositories
{
    public interface ISocialCommentRepository : IGenericRepository<SocialComment>
    {
        public Task<List<SocialCommentDTO>> GetCommentById(int postId);
    }
}
