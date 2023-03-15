namespace BlazorKnowledge.Server.Models;

public sealed record WeatherForecast
{
    public DateOnly Date { get; init; }

    public int TemperatureC { get; init; }

    public string Summary { get; init; } = string.Empty;
}
