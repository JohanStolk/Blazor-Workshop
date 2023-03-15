using BlazorKnowledge.Client;
using BlazorKnowledge.Flux;
using BlazorKnowledge.Proxies.BlazorKnowledge.Server;
using Fluxor;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("BlazorKnowledge.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("BlazorKnowledge.ServerAPI"));

builder.Services.AddFluxor(o => o.ScanAssemblies(typeof(AssemblyScanDetector).Assembly));

void ConfigureClient(HttpClient x) => x.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
builder.Services.AddHttpClient<IWeatherForecastClient, WeatherForecastClient>(ConfigureClient);
builder.Services.AddHttpClient<IAppInfoClient, AppInfoClient>(ConfigureClient);

await builder.Build().RunAsync();
