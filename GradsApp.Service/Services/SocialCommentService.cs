using GradsApp.Core.Models;
using GradsApp.Repository.IRepositories;
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
        public readonly ISocialCommentRepository _socialCommentRepository;

        public SocialCommentService(ISocialCommentRepository socialCommentRepository)
        {
            _socialCommentRepository = socialCommentRepository;
        }

        public Task CreatePost(SocialComment comment)
        {
            return _socialCommentRepository.CreateAsync(comment);
        }

        public async Task<List<SocialComment>> GetAll()
        {
            return await _socialCommentRepository.GetAllAsync();
        }
    }
}
