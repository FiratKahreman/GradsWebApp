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
    public class UserProfileService : IUserProfileService
    {
        private readonly IUserProfileRepository _userProfileRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserProfileService(IUnitOfWork unitOfWork, IUserProfileRepository userProfileRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _userProfileRepository = userProfileRepository;
            _mapper = mapper;
        }

        public async Task<string> Login(LoginDTO loginDTO)
        {
            var userResponse = await _userProfileRepository.GetByFilterAsync(x => x.Mail == loginDTO.Mail && x.Password == loginDTO.Password);
            return userResponse == null ? null : loginDTO.Mail;

        }

        public async Task<UserProfile> SignUp(UserProfile userProfile)
        {
            await _userProfileRepository.CreateAsync(userProfile);
            await _unitOfWork.CommitAsync();
            return userProfile;
        }
        public async Task<UserProfileDTO> GetProfileById(int id)
        {
            var userResponse = await _userProfileRepository.GetByFilterAsync(x => x.Id == id);
            return _mapper.Map<UserProfileDTO>(userResponse);

        }
    }
}
