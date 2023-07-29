using BlazorWasm.Tvflix.Services;

namespace BlazorWasm.Tvflix.Pages
{
    public partial class PageMain
    {
        private readonly string _key = "3fd67b0a75a2861ff71511c8065512a7";
        private MovieList? _movieList;
        private BannerList? _bannerList;
        private MovieDetail? _movieDetail;
        private MovieCategoryList? _movieCategoryList;

        protected override async Task OnInitializedAsync()
        {
            _movieList = await MoiveListService.GetAsync(_key);
            _bannerList = await BannerListService.GetAsync(_key);
            _bannerList = await BannerListService.SetGenre(_bannerList, _movieList);
        }

        private async Task GetMovieList(Genre genre)
        {
            _movieCategoryList = await MovieCategoryListService.GetAsync(_key, genre.id);
            _movieCategoryList.category_title = genre.name;
        }

        private async Task WatchNowClick(int id)
        {
            _movieDetail = await MovieDetailService.GetAsync(id, _key);
            _movieCategoryList = null;
            StateHasChanged();
        }

        private void Default()
        {
            _movieDetail = null;
            _movieCategoryList = null;
            StateHasChanged();
        }
    }
}
