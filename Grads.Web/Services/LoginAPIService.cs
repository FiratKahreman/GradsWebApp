using GradsApp.Core.DTOs;
using System.Net.Http.Json;

namespace Grads.Web.Services
{
    public class LoginAPIService
    {
        private readonly HttpClient _httpClient;

        public LoginAPIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> UserIsValid(LoginDTO loginDto)
        {
            var isValid = _httpClient.PostAsJsonAsync($"Login/Login", loginDto);
            var bilmemne = await isValid.Result.Content.ReadAsStringAsync();
            if(bilmemne == "true")
                return true;

            return false;
        }
    }
}
