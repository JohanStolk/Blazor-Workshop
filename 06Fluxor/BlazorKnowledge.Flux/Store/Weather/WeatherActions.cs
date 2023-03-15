
using BlazorKnowledge.Proxies.BlazorKnowledge.Server;

namespace BlazorKnowledge.Flux.Store.Weather;

public sealed record WeatherFetchAction;
public sealed record WeatherFetchActionResult(ICollection<WeatherForecast> Result);
