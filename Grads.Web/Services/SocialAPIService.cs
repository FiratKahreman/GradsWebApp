using GradsApp.Core.DTOs;
using Newtonsoft.Json;

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
        public async void NewPost(CreatePostDTO post)
        {            
            var response = await _httpClient.PostAsJsonAsync<CreatePostDTO>("Social/NewPost", post);
        }
    }
}
