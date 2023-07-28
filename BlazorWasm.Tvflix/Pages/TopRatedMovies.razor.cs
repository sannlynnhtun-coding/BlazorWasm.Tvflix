using BlazorWasm.Tvflix.Services;

namespace BlazorWasm.Tvflix.Pages;

public partial class TopRatedMovies
{
    private readonly string _key = "3fd67b0a75a2861ff71511c8065512a7";
    private TopRatedMovieList? _topRatedMovieList;
    
    protected override async Task OnInitializedAsync()
    {
        _topRatedMovieList = await TopRatedMovieListService.GetAsync(_key);
    }
}