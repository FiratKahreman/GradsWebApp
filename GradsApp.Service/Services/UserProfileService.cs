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

        public async Task<string> Login(LoginDTO loginDTO)
        {
            var userResponse = await _userProfileRepository.GetByFilterAsync(x => x.Mail == loginDTO.Mail && x.Password == loginDTO.Password);
            if (userResponse != null)
            {
                string displayName = userResponse.FirstName + userResponse.LastName;
                var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("UserId", userResponse.Id.ToString()),
                        new Claim("DisplayName", userResponse.FirstName.ToString()),
                        new Claim("UserName", displayName.ToString()),
                        new Claim("Email", userResponse.Mail.ToString())
                    };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    _configuration["Jwt:Issuer"],
                    _configuration["Jwt:Audience"],
                    claims,
                    expires: DateTime.UtcNow.AddMinutes(2),
                    signingCredentials: signIn);
                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            else
            {
                return null;
            }       
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
