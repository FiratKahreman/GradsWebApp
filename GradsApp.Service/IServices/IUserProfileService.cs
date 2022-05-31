using GradsApp.Core.DTOs;
using GradsApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Service.IServices
{
    public interface IUserProfileService
    {
        public Task<string> Login(LoginDTO loginDTO);
        public Task<UserProfileDTO> GetProfileById(int id);
        public Task<UserProfile> SignUp(UserProfile userProfile);

    }
}
