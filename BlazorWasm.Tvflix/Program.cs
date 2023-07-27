using BlazorWasm.Tvflix;
using BlazorWasm.Tvflix.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient());
builder.Services.AddScoped<MovieListService>();
builder.Services.AddScoped<BannerListService>();

await builder.Build().RunAsync();
