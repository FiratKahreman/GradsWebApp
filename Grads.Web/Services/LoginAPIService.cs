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
            var response = await isValid.Result.Content.ReadAsStringAsync();
            if(response == "true")
                return true;

            return false;
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
