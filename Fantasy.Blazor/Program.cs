using Fantasy.Blazor;
using Fantasy.Common.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//API
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7181") });

//Helpers
builder.Services.AddScoped<IApiService, ApiService>();


await builder.Build().RunAsync();
