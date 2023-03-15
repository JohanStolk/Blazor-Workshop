using Fluxor;

namespace BlazorKnowledge.Flux.Store.Weather;

/// <summary>
/// static class with static methods.
/// This is intentional since a Reducer method should be a pure method with no side effects.
/// if you find yourself needing to inject dependencies into a reducer then you might be taking the wrong approach.
/// </summary>
public static class WeatherReducers
{
    [ReducerMethod]
    public static WeatherState Reduce(WeatherState state, WeatherFetchAction action) =>
        state with
        {
            IsLoading = true
        };
    [ReducerMethod]
    public static WeatherState Reduce(WeatherState state, WeatherFetchActionResult action) =>
        state with
        {
            IsLoading = false,
            Report = action.Result
        };

}
