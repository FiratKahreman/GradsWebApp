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

        public Task CreateComment(SocialComment comment)
        {
            _socialCommentRepository.CreateAsync(comment);
            _unitOfWork.Commit();
            return Task.CompletedTask;
        }

        public async Task<List<SocialCommentDTO>> GetCommentByPost(int postId)
        {
            return await _socialCommentRepository.GetCommentById(postId);
        }
    }
}
