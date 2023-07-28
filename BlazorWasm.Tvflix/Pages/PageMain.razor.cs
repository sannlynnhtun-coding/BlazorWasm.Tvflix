using BlazorWasm.Tvflix.Services;

namespace BlazorWasm.Tvflix.Pages
{
    public partial class PageMain
    {
        private readonly string _key = "3fd67b0a75a2861ff71511c8065512a7";
        private MovieList? _movieList;
        private BannerList? _bannerList;

        protected override async Task OnInitializedAsync()
        {
            _movieList = await MoiveListService.GetAsync(_key);
            _bannerList = await BannerListService.GetAsync(_key);
            _bannerList = await BannerListService.SetGenre(_bannerList, _movieList);
        }

        private void GetMovieList(Genre genre)
        {
            string a = genre.name;
        }
    }
}
