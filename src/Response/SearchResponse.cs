using System.Text.Json.Serialization;

namespace OpenSky.Core.Response;

/// <summary>
/// Represents a search result containing location information.
/// </summary>
/// <param name="Id">The unique identifier of the search result.</param>
/// <param name="Name">The name of the location.</param>
/// <param name="Region">The region of the location.</param>
/// <param name="Country">The country of the location.</param>
/// <param name="Lat">The latitude of the location.</param>
/// <param name="Lon">The longitude of the location.</param>
/// <param name="Url">The URL associated with the location.</param>
public sealed record Search(
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("region")] string Region,
    [property: JsonPropertyName("country")] string Country,
    [property: JsonPropertyName("lat")] decimal Lat,
    [property: JsonPropertyName("lon")] decimal Lon,
    [property: JsonPropertyName("url")] string Url);