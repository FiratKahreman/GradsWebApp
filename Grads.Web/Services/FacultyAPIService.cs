using GradsApp.Core.Models;

namespace Grads.Web.Services
{
    public class FacultyAPIService
    {
        private readonly HttpClient _httpClient;

        public FacultyAPIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Faculty>> GetFaculties()
        {
            var response = await _httpClient.GetFromJsonAsync<List<Faculty>>("faculty");
            return response.ToList();
        }
    }
}
