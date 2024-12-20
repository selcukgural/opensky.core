using System.Text.Json.Serialization;

namespace OSS.Core.Model;

/// <summary>
/// Represents a forecast for a specific day.
/// </summary>
/// <param name="Date">The date of the forecast.</param>
/// <param name="DateEpoch">The epoch time of the forecast date.</param>
/// <param name="Day">The weather data for the day.</param>
/// <param name="Astro">The astronomical data for the day.</param>
/// <param name="Hour">The hourly weather data for the day.</param>
public record ForecastDay(
    [property: JsonPropertyName("date")] string Date,
    [property: JsonPropertyName("date_epoch")] int DateEpoch,
    [property: JsonPropertyName("day")] Day Day,
    [property: JsonPropertyName("astro")] Astro Astro,
    [property: JsonPropertyName("hour")] IReadOnlyList<Hour> Hour);