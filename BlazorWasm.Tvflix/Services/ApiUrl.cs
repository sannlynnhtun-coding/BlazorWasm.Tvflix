namespace BlazorWasm.Tvflix.Services
{
    public class ApiUrl
    {
        public const string MovieList = "https://api.themoviedb.org/3/genre/movie/list?api_key={0}";
        public const string PopularList = "https://api.themoviedb.org/3/movie/popular?api_key={0}&page=1";
        public const string TopRatedList = "https://api.themoviedb.org/3/movie/top_rated?api_key={0}&page=1";
        public const string MovieDetail = "https://api.themoviedb.org/3/movie/{0}?api_key={1}&append_to_response=casts,videos,images,releases";
        public const string WeeklyTrendingMovieList = "https://api.themoviedb.org/3/trending/movie/week?api_key={0}&page=1";
        public const string MoviveCategoryList = "https://api.themoviedb.org/3/discover/movie?api_key={0}&sort_by=popularity.desc&include_adult=false&page=1&with_genres={1}";
        public const string UpComingList = "https://api.themoviedb.org/3/movie/upcoming?api_key={0}&page=1";
    }
}
