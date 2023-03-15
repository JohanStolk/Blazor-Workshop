
using BlazorKnowledge.Proxies.BlazorKnowledge.Server;

namespace BlazorKnowledge.Flux.Store.AppInfo;

public sealed record AppInfoFetchAction;
public sealed record AppInfoFetchActionResult(AppInfoDto AppInfoDto);
