using Newtonsoft.Json;

namespace BlazorWasm.Tvflix.Services
{
    public class MovieDetailService
    {
        private readonly HttpClient _httpClient;

        public MovieDetailService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<MovieDetail?> GetAsync(int id, string key)
        {
            string url = string.Format(ApiUrl.MovieDetail, id, key);
            var response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string jsonStr = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<MovieDetail>(jsonStr);
            }
            return null;
        }
    }

    public class MovieDetail
    {
        public bool adult { get; set; }
        public string backdrop_path { get; set; }
        public object belongs_to_collection { get; set; }
        public int budget { get; set; }
        public Genre[] genres { get; set; }
        public string homepage { get; set; }
        public int id { get; set; }
        public string imdb_id { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public string overview { get; set; }
        public float popularity { get; set; }
        public string poster_path { get; set; }
        public Production_Companies[] production_companies { get; set; }
        public Production_Countries[] production_countries { get; set; }
        public string release_date { get; set; }
        public int revenue { get; set; }
        public int runtime { get; set; }
        public Spoken_Languages[] spoken_languages { get; set; }
        public string status { get; set; }
        public string tagline { get; set; }
        public string title { get; set; }
        public bool video { get; set; }
        public float vote_average { get; set; }
        public int vote_count { get; set; }
        public Casts casts { get; set; }
        public Videos videos { get; set; }
        public Images images { get; set; }
        public Releases releases { get; set; }
    }

    public class Casts
    {
        public Cast[] cast { get; set; }
        public Crew[] crew { get; set; }
    }

    public class Cast
    {
        public bool adult { get; set; }
        public int gender { get; set; }
        public int id { get; set; }
        public string known_for_department { get; set; }
        public string name { get; set; }
        public string original_name { get; set; }
        public float popularity { get; set; }
        public string profile_path { get; set; }
        public int cast_id { get; set; }
        public string character { get; set; }
        public string credit_id { get; set; }
        public int order { get; set; }
    }

    public class Crew
    {
        public bool adult { get; set; }
        public int gender { get; set; }
        public int id { get; set; }
        public string known_for_department { get; set; }
        public string name { get; set; }
        public string original_name { get; set; }
        public float popularity { get; set; }
        public string profile_path { get; set; }
        public string credit_id { get; set; }
        public string department { get; set; }
        public string job { get; set; }
    }

    public class Videos
    {
        public Results[] results { get; set; }
    }

    public class Results
    {
        public string iso_639_1 { get; set; }
        public string iso_3166_1 { get; set; }
        public string name { get; set; }
        public string key { get; set; }
        public string site { get; set; }
        public int size { get; set; }
        public string type { get; set; }
        public bool official { get; set; }
        public DateTime published_at { get; set; }
        public string id { get; set; }
    }

    public class Images
    {
        public Backdrop[] backdrops { get; set; }
        public Logo[] logos { get; set; }
        public Poster[] posters { get; set; }
    }

    public class Backdrop
    {
        public float aspect_ratio { get; set; }
        public int height { get; set; }
        public string iso_639_1 { get; set; }
        public string file_path { get; set; }
        public float vote_average { get; set; }
        public int vote_count { get; set; }
        public int width { get; set; }
    }

    public class Logo
    {
        public float aspect_ratio { get; set; }
        public int height { get; set; }
        public string iso_639_1 { get; set; }
        public string file_path { get; set; }
        public float vote_average { get; set; }
        public int vote_count { get; set; }
        public int width { get; set; }
    }

    public class Poster
    {
        public float aspect_ratio { get; set; }
        public int height { get; set; }
        public string iso_639_1 { get; set; }
        public string file_path { get; set; }
        public float vote_average { get; set; }
        public int vote_count { get; set; }
        public int width { get; set; }
    }

    public class Releases
    {
        public Country[] countries { get; set; }
    }

    public class Country
    {
        public string certification { get; set; }
        public object[] descriptors { get; set; }
        public string iso_3166_1 { get; set; }
        public bool primary { get; set; }
        public string release_date { get; set; }
    }

    //public class Genre
    //{
    //    public int id { get; set; }
    //    public string name { get; set; }
    //}

    public class Production_Companies
    {
        public int id { get; set; }
        public string logo_path { get; set; }
        public string name { get; set; }
        public string origin_country { get; set; }
    }

    public class Production_Countries
    {
        public string iso_3166_1 { get; set; }
        public string name { get; set; }
    }

    public class Spoken_Languages
    {
        public string english_name { get; set; }
        public string iso_639_1 { get; set; }
        public string name { get; set; }
    }

}
