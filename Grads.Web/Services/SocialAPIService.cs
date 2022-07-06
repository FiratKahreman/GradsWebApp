using Grads.Web.Models;
using GradsApp.Core.DTOs;
using GradsApp.Service.IServices;
using Newtonsoft.Json;

namespace Grads.Web.Services
{
    public class SocialAPIService
    {
        private readonly HttpClient _httpClient;
        private readonly ISocialPostService _service;
        public SocialAPIService(HttpClient httpClient, ISocialPostService service)
        {
            _httpClient = httpClient;
            _service = service;
        }

        public async Task<List<SocialPostDTO>> GetPosts()
        {
            var posts = await _httpClient.GetFromJsonAsync<List<SocialPostDTO>>("Social/GetPosts");
            
            return posts;
        }
        public async void NewPost(CreatePostDTO createPostDTO)
        {            
            var response = await _httpClient.PostAsJsonAsync<CreatePostDTO>("Social/NewPost", createPostDTO);
        }

        public async void NewComment(CreateCommentDTO createCommentDTO)
        {
            var response = await _httpClient.PostAsJsonAsync<CreateCommentDTO>("Social/NewComment", createCommentDTO);
        }

        public async Task<string> AddLike(int id)
        {
            var response = await _httpClient.PostAsJsonAsync("Social/AddLike", id);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
