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

        public async Task<MovieCategoryList?> GetAsync(string key, int genre=0, 
            int pageNo = 1,EnumMovieSearchType movieSearchType = EnumMovieSearchType.Category,
            string keyword = null)
        {
            
            string url = movieSearchType == EnumMovieSearchType.Keyword ? 
            string.Format(ApiUrl.MovieSearch, key, keyword)  :
            string.Format(ApiUrl.MovieCategoryList, key, pageNo, genre);
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
