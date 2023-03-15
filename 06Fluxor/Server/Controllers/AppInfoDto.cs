namespace BlazorKnowledge.Server.Controllers;

public record AppInfoDto(DateTimeOffset ServerTime, string Version, string UserName);
