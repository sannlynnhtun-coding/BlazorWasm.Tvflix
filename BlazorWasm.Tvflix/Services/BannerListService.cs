namespace BlazorWasm.Tvflix.Services
{
    public class BannerListService
    {
        private readonly HttpClient _httpClient;

        public BannerListService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<BannerList?> GetAsync(string key)
        {
            string url = string.Format(ApiUrl.PopularList, key);
            var response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string jsonStr = await response.Content.ReadAsStringAsync();
                return jsonStr.ToObject<BannerList>();
            }
            return null;
        }
    }
}
