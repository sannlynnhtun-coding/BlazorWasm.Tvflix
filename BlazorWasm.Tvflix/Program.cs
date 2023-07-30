using BlazorWasm.Tvflix;
using BlazorWasm.Tvflix.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddMudServices();
builder.Services.AddScoped<HttpClient>();
builder.Services.AddScoped<MovieListService>();
builder.Services.AddScoped<BannerListService>();
builder.Services.AddScoped<TopRatedMovieListService>();
builder.Services.AddScoped<WeeklyTrendingMovieListService>();
builder.Services.AddScoped<MovieDetailService>();
builder.Services.AddScoped<MovieCategoryListService>();
builder.Services.AddScoped<UpComingMovieListService>();
builder.Services.AddScoped<RecommendationsService>();

await builder.Build().RunAsync();
