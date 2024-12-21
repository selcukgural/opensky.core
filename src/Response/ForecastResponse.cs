using System.Text.Json.Serialization;
using OpenSky.Core.Model;

namespace OpenSky.Core.Response;

/// <summary>
/// Represents the response containing forecast information.
/// </summary>
/// <param name="Location">The location information.</param>
/// <param name="Current">The current weather information.</param>
/// <param name="Forecast">The forecast information.</param>
/// <param name="Alerts">The alerts information.</param>
public sealed record ForecastResponse(
    [property: JsonPropertyName("location")] Location Location,
    [property: JsonPropertyName("current")] Current Current,
    [property: JsonPropertyName("forecast")] Forecast Forecast,
    [property: JsonPropertyName("alerts")] Alerts Alerts);