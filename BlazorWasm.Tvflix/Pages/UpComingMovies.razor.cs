using BlazorWasm.Tvflix.Services;

namespace BlazorWasm.Tvflix.Pages;

public partial class UpComingMovies
{
    private readonly string _key = "3fd67b0a75a2861ff71511c8065512a7";
    private UpComingMovieList? _upComingMovieList;

    protected override async Task OnInitializedAsync()
    {
        _upComingMovieList = await UpComingMovieListService.GetAsync(_key);
    }
}