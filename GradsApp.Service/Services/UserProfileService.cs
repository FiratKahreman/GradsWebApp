using AutoMapper;
using GradsApp.API.Helpers;
using GradsApp.Core.DTOs;
using GradsApp.Core.Models;
using GradsApp.Repository.IRepositories;
using GradsApp.Repository.IUnitOfWorks;
using GradsApp.Service.IServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Service.Services
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IUserProfileRepository _userProfileRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public UserProfileService(IUnitOfWork unitOfWork, IUserProfileRepository userProfileRepository, IMapper mapper, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _userProfileRepository = userProfileRepository;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<bool> Login(LoginDTO loginDTO)
        {
            var userResponse = await _userProfileRepository.GetByFilterAsync(x => x.Mail == loginDTO.Mail && x.Password == loginDTO.Password);
            return userResponse != null? true : false;     
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
            
            var userDto = _mapper.Map<UserProfileDTO>(userResponse);
            Console.WriteLine(userDto.FirstName);
            return userDto;

        }
    }
}
