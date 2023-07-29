using Newtonsoft.Json;

namespace BlazorWasm.Tvflix.Services
{
    public class MovieCategoryListService
    {
        private readonly HttpClient _httpClient;

        public MovieCategoryListService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<MovieCategoryList?> GetAsync(string key, int genre, int pageNo = 1)
        {
            string url = string.Format(ApiUrl.MovieCategoryList, key, pageNo, genre);
            var response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string jsonStr = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<MovieCategoryList>(jsonStr);
            }
            return null;
        }
    }
}
