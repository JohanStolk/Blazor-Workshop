using Fluxor;

namespace BlazorKnowledge.Flux.Store.AppInfo;

/// <summary>
/// This is the class that will hold the values of your state to be displayed in your application.
/// Note: State should be immutable
///  https://github.com/mrpmorris/Fluxor/blob/master/Source/Tutorials/02-Blazor/02A-StateActionsReducersTutorial/README.md
/// </summary>
[FeatureState]
public sealed record AppInfoState
{
    public DateTimeOffset? ServerTime { get; init; }
    public string Version { get; init; } = string.Empty;
    public string UserName { get; init; } = string.Empty;
}
