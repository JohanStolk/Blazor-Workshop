using BlazorKnowledge.Proxies.BlazorKnowledge.Server;
using Fluxor;

namespace BlazorKnowledge.Flux.Store.Weather;

/// <summary>
/// This is the class that will hold the values of your state to be displayed in your application.
/// Note: State should be immutable
///  https://github.com/mrpmorris/Fluxor/blob/master/Source/Tutorials/02-Blazor/02A-StateActionsReducersTutorial/README.md
/// </summary>
[FeatureState]
public sealed record WeatherState
{
    public bool IsLoading { get; init; }
    public ICollection<WeatherForecast> Report { get; init; } = new List<WeatherForecast>();
}
