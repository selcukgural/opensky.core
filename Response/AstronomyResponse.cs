using System.Text.Json.Serialization;
using OSS.Core.Model;

namespace OSS.Core.Response;

/// <summary>
/// Represents the response containing astronomy information.
/// </summary>
/// <param name="Location">The location information.</param>
/// <param name="Astronomy">The astronomy information.</param>
public sealed record AstronomyResponse(
    [property: JsonPropertyName("location")] Location Location,
    [property: JsonPropertyName("astronomy")] Astronomy Astronomy);