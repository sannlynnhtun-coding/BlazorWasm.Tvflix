using BlazorWasm.Tvflix.Services;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorWasm.Tvflix.Pages
{
    public partial class PageMain
    {
        private MovieList? _movieList;
        private BannerList? _bannerList;
        private MovieDetail? _movieDetail;
        private MovieCategoryList? _movieCategoryList;
        private string? _id;
        private string? _search;
        private bool _isSearchCategory;

        protected override async Task OnInitializedAsync()
        {
            await Default();
            StateContainer.OnChange += StateHasChanged;
        }

        private async Task GetMovieList(Genre genre)
        {
            _movieCategoryList = await MovieCategoryListService.GetAsync(ApiKey.Value, genre.id);
            if (_movieCategoryList != null)
            {
                _movieCategoryList.genre_id = genre.id;
                _movieCategoryList.genre_name = genre.name;
            }

            StateContainer.Id = 0;
            _movieDetail = null;
            _isSearchCategory = true;
        }

        private async Task WatchNowClick(int id)
        {
            // _movieDetail = await MovieDetailService.GetAsync(id, ApiKey.Value);
            StateContainer.Id = id;
            _movieCategoryList = null;
            // StateHasChanged();
        }

        private async Task Default()
        {
            _isSearchCategory = false;
            _movieList = await MoiveListService.GetAsync(ApiKey.Value);
            _bannerList = await BannerListService.GetAsync(ApiKey.Value);
            _bannerList = await BannerListService.SetGenre(_bannerList, _movieList);
            _movieDetail = null;
            _movieCategoryList = null;
            StateContainer.Id = 0;
            StateHasChanged();
        }
        public void Dispose()
        {
            StateContainer.OnChange -= StateHasChanged;
        }
        
        private async Task HandelKeyPress(KeyboardEventArgs e)
        {
            if (e.Key is not "Enter")
                return;
            _movieCategoryList =await MovieCategoryListService.GetAsync(ApiKey.Value,
                movieSearchType: EnumMovieSearchType.Keyword, keyword : _search);
            StateContainer.Id = 0;
            _movieDetail = null;
            _isSearchCategory = true;
            StateHasChanged();
        }
    }
}