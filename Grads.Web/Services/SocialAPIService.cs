using Grads.Web.Models;
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
            var context = new SocialModel();
            var posts = await _httpClient.GetFromJsonAsync<List<SocialPostDTO>>("Social/GetPosts");
            context.SocialPostDTOs = posts;
            return posts;
        }
        public async void NewPost(CreatePostDTO createPostDTO)
        {            
            var response = await _httpClient.PostAsJsonAsync<CreatePostDTO>("Social/NewPost", createPostDTO);
        }

        public async void NewComment(SocialCommentDTO socialCommentDTO)
        {
            var response = await _httpClient.PostAsJsonAsync<SocialCommentDTO>("Social/NewComment", socialCommentDTO);
        }
    }
}
