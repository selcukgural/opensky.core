using System.Text.Json.Serialization;

namespace OpenSky.Core.Model;

/// <summary>
/// Location object is returned with each API response. It is actually the matched location for which the information has been returned.
/// <see href="https://www.weatherapi.com/docs/"/>
/// </summary>
/// <param name="Name">The name of the location.</param>
/// <param name="Region">The region where the location is situated.</param>
/// <param name="Country">The country where the location is situated.</param>
/// <param name="Lat">The latitude of the location.</param>
/// <param name="Lon">The longitude of the location.</param>
/// <param name="TzId">The timezone identifier of the location.</param>
/// <param name="LocaltimeEpoch">The local time in epoch format.</param>
/// <param name="Localtime">The local time as a string.</param>
public sealed record Location(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("region")] string Region,
    [property: JsonPropertyName("country")] string Country,
    [property: JsonPropertyName("lat")] decimal Lat,
    [property: JsonPropertyName("lon")] decimal Lon,
    [property: JsonPropertyName("tz_id")] string TzId,
    [property: JsonPropertyName("localtime_epoch")] int LocaltimeEpoch,
    [property: JsonPropertyName("localtime")] string Localtime);