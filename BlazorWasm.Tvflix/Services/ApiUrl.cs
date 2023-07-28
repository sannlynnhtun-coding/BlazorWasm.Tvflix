namespace BlazorWasm.Tvflix.Services
{
    public class ApiUrl
    {
        public const string MovieList = "https://api.themoviedb.org/3/genre/movie/list?api_key={0}";
        public const string PopularList = "https://api.themoviedb.org/3/movie/popular?api_key={0}&page=1";
        public const string MovieDetail = "https://api.themoviedb.org/3/movie/{0}?api_key={1}&append_to_response=casts,videos,images,releases";
    }
}
