using GradsApp.Core.DTOs;
using GradsApp.Core.Models;
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


        public async Task<UserProfile> UserIsValid(LoginDTO loginDto)
        {
            var isValid = await _httpClient.PostAsJsonAsync($"Login/Login", loginDto);
            var response = await isValid.Content.ReadFromJsonAsync<UserProfile>();
            
            return response??null;
        }

        public async Task<string> SignUp(SignUpDTO signUpDto)
        {
            

            
            var response = await _httpClient.PostAsJsonAsync($"Login/SignUp", signUpDto);
            var profileId = await response.Content.ReadAsStringAsync();

            if (signUpDto.GotCard == true)
            {
                var cardDto = new NewCardDTO() { CardProfileId = Int32.Parse(profileId) };
                var cardResponse = _httpClient.PostAsJsonAsync($"Card/NewCard", cardDto);
            }

            return signUpDto.FirstName;


        }
    }
}
