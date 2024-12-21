using System.Text.Json.Serialization;
using OpenSky.Core.Model;

namespace OpenSky.Core.Response;

/// <summary>
/// Represents the response containing marine forecast information.
/// </summary>
/// <param name="Location">The location information.</param>
/// <param name="Forecast">The forecast information.</param>
public sealed record MarineResponse(
    [property: JsonPropertyName("location")] Location Location,
    [property: JsonPropertyName("forecast")] Forecast Forecast);