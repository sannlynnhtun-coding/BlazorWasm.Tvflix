using BlazorWasm.Tvflix.Services;

namespace BlazorWasm.Tvflix.Pages;

public partial class PageWeeklyTrendingMovieList
{
    private WeeklyTrendingMovieList? _weeklyTrendingMovieList;
    private readonly string _key = "3fd67b0a75a2861ff71511c8065512a7";

    protected override async Task OnInitializedAsync()
    {
        _weeklyTrendingMovieList = await WeeklyTrendingMovieListService.GetAsync(_key);
    }
}