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

        public async Task<BannerList?> SetGenre(BannerList? bannerList, MovieList? movieList)
        {
            foreach (var banner in bannerList.results)
            {
                banner.genre_name = GetString(banner.genre_ids, movieList.genres);
            }
            return bannerList;
        }

        public string GetString(List<int> genre_ids , Genre[] genres)
        {
            string MoveCategorie = string.Empty;
            int counter = 1;
            foreach(var banner in genre_ids)
            {
                foreach (var item in genres)
                {
                    if(banner == item.id && counter < genre_ids.Count)
                    {
                        MoveCategorie += $"{item.name},";
                        counter++;
                    }
                    else if (banner == item.id && counter == genre_ids.Count)
                    {
                        MoveCategorie += $"{item.name}";
                        counter++;
                    }
                }
            }
            return MoveCategorie;
        }
    }
}
