﻿using GradsApp.Core.DTOs;
using GradsApp.Core.Models;
using GradsApp.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Repository.Repositories
{
    public class SocialPostRepository : GenericRepository<SocialPost>, ISocialPostRepository
    {

        private readonly AppDbContext _appDbContext;

        public SocialPostRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<SocialPostDTO>> GetAllPosts()
        {
            List<SocialPostDTO> socialPost = (from a in _appDbContext.UserProfiles
                                              join b in _appDbContext.SocialPosts on a.Id equals b.PostProfileId


                                                               select new SocialPostDTO
                                                               {
                                                                   SocialPostId = b.Id,
                                                                   Name = a.FirstName,
                                                                   Surname = a.LastName,
                                                                   IsGrad = a.IsGrad,
                                                                   Likes = b.Likes,
                                                                   PostText = b.PostText,
                                                                   PostProfileId = b.PostProfileId,
                                                                   CreatedDate = b.CreatedDate,
                                                                   PostTitle = b.PostTitle
                                                                   
                                                               }).ToList();
            return socialPost;
        }
    }
}
