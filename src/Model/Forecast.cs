using System.Text.Json.Serialization;

namespace OSS.Core.Model;

/// <summary>
/// Represents a weather forecast.
/// </summary>
/// <param name="ForecastDay">The list of forecast days.</param>
public sealed record Forecast(
    [property: JsonPropertyName("forecastday")] IReadOnlyList<ForecastDay> ForecastDay
);