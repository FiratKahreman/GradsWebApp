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
    public class SocialCommentService : ISocialCommentService
    {
        private readonly ISocialCommentRepository _socialCommentRepository;
        private readonly IUnitOfWork _unitOfWork;

        public SocialCommentService(ISocialCommentRepository socialCommentRepository, IUnitOfWork unitOfWork)
        {
            _socialCommentRepository = socialCommentRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<SocialComment> CreateComment(SocialComment comment)
        {
            await _socialCommentRepository.CreateAsync(comment);
            await _unitOfWork.CommitAsync();
            return comment;
        }

        public async Task<List<SocialCommentDTO>> GetCommentByPost(int postId)
        {
            return await _socialCommentRepository.GetCommentById(postId);
        }
    }
}
