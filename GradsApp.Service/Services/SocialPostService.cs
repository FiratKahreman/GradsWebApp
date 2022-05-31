using GradsApp.Core.DTOs;
using GradsApp.Core.Models;
using GradsApp.Repository.IRepositories;
using GradsApp.Repository.IUnitOfWorks;
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
        private readonly IUnitOfWork _unitOfWork;

        public SocialPostService(ISocialPostRepository socialPostRepository, IUnitOfWork unitOfWork)
        {
            _socialPostRepository = socialPostRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<SocialPost> CreatePost(SocialPost post)
        {
            await _socialPostRepository.CreateAsync(post);
            await _unitOfWork.CommitAsync();
            return post;
        }

        public async Task<List<SocialPostDTO>> GetAllPosts()
        {
            return await _socialPostRepository.GetAllPosts();
        }
    }
}
