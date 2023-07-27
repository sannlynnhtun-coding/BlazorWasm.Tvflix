using Newtonsoft.Json;

namespace BlazorWasm.Tvflix.Services
{
    public class MovieListService
    {
        private readonly HttpClient _httpClient;

        public MovieListService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<MovieList?> GetAsync(string key)
        {
            string url = string.Format(ApiUrl.MovieList, key);
            var response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string jsonStr = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<MovieList>(jsonStr);
            }
            return null;
        }
    }
}
