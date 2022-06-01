using GradsApp.Core.DTOs;
using GradsApp.Core.Models;

namespace Grads.Web.Services
{
    public class ProfileAPIService
    {
        private readonly HttpClient _httpClient;

        public ProfileAPIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<UserProfileDTO> GetProfile(int id)
        {
            var profile = await _httpClient.GetFromJsonAsync<UserProfileDTO>("UserProfile/1");
            Console.WriteLine(profile.FirstName);
            return profile;
        }
    }
}
