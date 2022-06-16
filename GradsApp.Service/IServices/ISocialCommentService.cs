using GradsApp.Core.DTOs;
using GradsApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Service.IServices
{
    public interface ISocialCommentService
    {
        public Task<List<SocialCommentDTO>> GetCommentByPost(int postId);
        public Task<SocialComment> CreateComment(SocialComment comment);
    }
}
