using System.Text.Json.Serialization;
using OSS.Core.Model;

namespace OSS.Core.Response;

/// <summary>
/// Represents the response containing current weather information.
/// </summary>
/// <param name="Location">The location information.</param>
/// <param name="Current">The current weather information.</param>
public sealed record CurrentResponse(
    [property: JsonPropertyName("location")] Location Location,
    [property: JsonPropertyName("current")] Current Current);