using BlazorWasm.Tvflix.Services;

namespace BlazorWasm.Tvflix.Pages
{
    public partial class PageMain
    {
        private MovieList? _movieList;
        private BannerList? _bannerList;
        private MovieDetail? _movieDetail;
        private MovieCategoryList? _movieCategoryList;
        private bool _isSearchCategory;

        protected override async Task OnInitializedAsync()
        {
            await Default();
        }

        private async Task GetMovieList(Genre genre)
        {
            _movieCategoryList = await MovieCategoryListService.GetAsync(ApiKey.Value, genre.id);
            if (_movieCategoryList != null)
            {
                _movieCategoryList.genre_id = genre.id;
                _movieCategoryList.genre_name = genre.name;
            }

            _movieDetail = null;
            _isSearchCategory = true;
        }

        private async Task WatchNowClick(int id)
        {
            _movieDetail = await MovieDetailService.GetAsync(id, ApiKey.Value);
            _movieCategoryList = null;
            StateHasChanged();
        }

        private async Task Default()
        {
            _isSearchCategory = false;
            _movieList = await MoiveListService.GetAsync(ApiKey.Value);
            _bannerList = await BannerListService.GetAsync(ApiKey.Value);
            _bannerList = await BannerListService.SetGenre(_bannerList, _movieList);
            _movieDetail = null;
            _movieCategoryList = null;
            StateHasChanged();
        }
    }
}