using GradsApp.Core.DTOs;

namespace Grads.Web.Services
{
    public class SocialAPIService
    {
        private readonly HttpClient _httpClient;

        public SocialAPIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<SocialPostDTO>> GetPosts()
        {
            var posts = await _httpClient.GetFromJsonAsync<List<SocialPostDTO>>("Social/GetPosts");
            return posts;
        }
    }
}
