using Fluxor;

namespace BlazorKnowledge.Flux.Store.AppInfo;

/// <summary>
/// static class with static methods.
/// This is intentional since a Reducer method should be a pure method with no side effects.
/// if you find yourself needing to inject dependencies into a reducer then you might be taking the wrong approach.
/// </summary>
public static class AppInfoReducers
{
    [ReducerMethod]
    public static AppInfoState Reduce(AppInfoState state, AppInfoFetchActionResult action) =>
        state with
        {
            UserName = action.AppInfoDto.UserName,
            ServerTime = action.AppInfoDto.ServerTime,
            Version = action.AppInfoDto.Version,
        };

}
