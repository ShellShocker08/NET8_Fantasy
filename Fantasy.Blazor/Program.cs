global using Microsoft.AspNetCore.Components.Web;

global using Fantasy.Blazor;

global using Fantasy.Common.Services;
global using Fantasy.Common.Entities;
global using Fantasy.Common.Resources;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//API
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7181") });

//Helpers
builder.Services.AddScoped<IApiService, ApiService>();

//Idiomas
builder.Services.AddLocalization();


await builder.Build().RunAsync();
