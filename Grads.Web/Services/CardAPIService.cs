using GradsApp.Core.DTOs;

namespace Grads.Web.Services
{
    public class CardAPIService
    {
        private readonly HttpClient _httpClient;

        public CardAPIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CardDTO> GetCard(int id)
        {
            var card = await _httpClient.GetFromJsonAsync<CardDTO>($"Card/GetCard/{id}");
            return card;
        }
    }
}
