using Newtonsoft.Json;

namespace BlazorWasm.Tvflix.Services;

public class WeeklyTrendingMovieListService
{
    private readonly HttpClient _httpClient;

    public WeeklyTrendingMovieListService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<WeeklyTrendingMovieList?> GetAsync(string key)
    {
        string url = string.Format(ApiUrl.WeeklyTrendingMovieList, key);
        var response = await _httpClient.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            string jsonStr = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<WeeklyTrendingMovieList?>(jsonStr);
        }
        return null;
    }
}
