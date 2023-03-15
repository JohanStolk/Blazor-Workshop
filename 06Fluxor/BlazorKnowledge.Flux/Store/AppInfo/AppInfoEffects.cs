using BlazorKnowledge.Proxies.BlazorKnowledge.Server;
using Fluxor;

namespace BlazorKnowledge.Flux.Store.AppInfo;

/// <summary>
/// An Effect method can access outside resources, and in turn dispatch Actions itself that will be processed
/// by Reducers to emit new State.
/// A class that contains Effect methods is an instance class (non-static) that can, through its constructor,
/// have resources injected into it on instantiation. Anything that can be injected into a component using the
/// standard dependency injection mechanism in Blazor can be injected into an Effect class instance.
/// </summary>
public sealed class AppInfoEffects
{
    private readonly IAppInfoClient _client;

    public AppInfoEffects(IAppInfoClient client) => _client = client;

    [EffectMethod]
    public async Task HandleAsync(AppInfoFetchAction action, IDispatcher dispatcher)
    {
        AppInfoDto result = await _client.GetAsync();
        dispatcher.Dispatch(new AppInfoFetchActionResult(result));
    }
}
