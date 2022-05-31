using GradsApp.Core.DTOs;
using GradsApp.Core.Models;
using GradsApp.Repository.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Repository.Repositories
{
    public class SocialCommentRepository : GenericRepository<SocialComment>, ISocialCommentRepository
    {
        private readonly AppDbContext _appDbContext;

        public SocialCommentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<SocialCommentDTO>> GetCommentById(int postId)
        {
            List<SocialCommentDTO> commentByPost =  await _appDbContext.SocialComments
                                                 .Where(a=>a.PostId == postId)
                                                .Select(a=> new SocialCommentDTO
                                                {   
                                                    CommentProfileId = a.CommentProfileId,
                                                    CommentText = a.CommentText,
                                                    PostId = postId

                                              }).ToListAsync();

            
            return commentByPost;
        }
    }
}
