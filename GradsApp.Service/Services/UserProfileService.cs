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
    public class UserProfileService : IUserProfileService
    {
        private readonly IUserProfileRepository _userProfileRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UserProfileService(IUnitOfWork unitOfWork, IUserProfileRepository userProfileRepository)
        {
            _unitOfWork = unitOfWork;
            _userProfileRepository = userProfileRepository;
        }

        public async Task<string> Login(LoginDTO loginDTO)
        {
            var userResponse = await _userProfileRepository.GetByFilterAsync(x => x.Mail == loginDTO.Mail && x.Password == loginDTO.Password);
            return userResponse == null ? null : loginDTO.Mail;

        }
    }
}
