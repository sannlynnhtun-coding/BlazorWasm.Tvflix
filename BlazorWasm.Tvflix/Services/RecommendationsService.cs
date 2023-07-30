using Newtonsoft.Json;

namespace BlazorWasm.Tvflix.Services;

public class RecommendationsService
{
    private readonly HttpClient _httpClient;

    public RecommendationsService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Recommendations?> GetAsync(int movieId, string key)
    {
        string url = string.Format(ApiUrl.RecommendationsList, movieId, key);
        var response = await _httpClient.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            string jsonStr = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Recommendations?>(jsonStr);
        }
        return null;
    }
}