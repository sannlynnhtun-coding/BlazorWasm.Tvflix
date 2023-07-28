namespace BlazorWasm.Tvflix.Services;

public class TopRatedMovieListService
{
    private readonly HttpClient _httpClient;

    public TopRatedMovieListService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<TopRatedMovieList?> GetAsync(string key)
    {
        string url = string.Format(ApiUrl.TopRatedList, key);
        var response = await _httpClient.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            string jsonStr = await response.Content.ReadAsStringAsync();
            return jsonStr.ToObject<TopRatedMovieList>();
        }
        return null;
    }
}
