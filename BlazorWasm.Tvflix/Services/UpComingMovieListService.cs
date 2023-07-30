namespace BlazorWasm.Tvflix.Services;

public class UpComingMovieListService
{
    private readonly HttpClient _httpClient;

    public UpComingMovieListService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<UpComingMovieList?> GetAsync(string key)
    {
        string url = string.Format(ApiUrl.UpComingList, key);
        var response = await _httpClient.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            var jsonStr = await response.Content.ReadAsStringAsync();
            return jsonStr.ToObject<UpComingMovieList>();
        }
        return null;
    }
}