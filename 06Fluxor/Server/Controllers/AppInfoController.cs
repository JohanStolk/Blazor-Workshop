using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace BlazorKnowledge.Server.Controllers;

/// <summary>
/// to get static info for the app
/// </summary>
[ApiController]
[Route("[controller]")]
public class AppInfoController : ControllerBase
{
    [Route("")]
    [HttpGet]
    public AppInfoDto Get()
    {
        string userName = "It's me!";
        AppInfoDto result = new(DateTimeOffset.UtcNow, Version: ProductVersion(), UserName: userName);
        return result;
    }

    private string ProductVersion() => FileVersionInfo.GetVersionInfo(GetType().Assembly.Location).ProductVersion ?? string.Empty;
}
