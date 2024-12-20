using System.Text.Json.Serialization;
using OSS.Core.Model;

namespace OSS.Core.Response;

/// <summary>
/// Represents the response containing future forecast information.
/// </summary>
/// <param name="Location">The location information.</param>
/// <param name="Forecast">The forecast information.</param>
public sealed record FutureResponse(
    [property: JsonPropertyName("location")] Location Location,
    [property: JsonPropertyName("forecast")] Forecast Forecast);