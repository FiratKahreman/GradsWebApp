using AutoMapper;
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
        private readonly IMapper _mapper;

        public SocialPostService(ISocialPostRepository socialPostRepository, IUnitOfWork unitOfWork)
        {
            _socialPostRepository = socialPostRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<SocialPost> CreatePost(SocialPost socialPost)
        {
            await _socialPostRepository.CreateAsync(socialPost);
            await _unitOfWork.CommitAsync();
            return socialPost;
        }

        public async Task<List<SocialPostDTO>> GetAllPosts()
        {
            return await _socialPostRepository.GetAllPosts();
        }

        public async Task<int> AddLike(int id)
        {
            var post = await _socialPostRepository.GetByIdAsync(id);
            
            await _socialPostRepository.UpdateAsync(post);
            await _unitOfWork.CommitAsync();
            return post.Likes;
        }
    }
}
