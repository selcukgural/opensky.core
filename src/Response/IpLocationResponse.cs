using System.Text.Json.Serialization;
using OSS.Core.Converter;

namespace OSS.Core.Response;

/// <summary>
/// Represents an IP location with various geographical and network details.
/// </summary>
/// <param name="Ip">IP address</param>
/// <param name="Type">IPv4 or IPv6</param>
/// <param name="ContinentCode">Continent code</param>
/// <param name="ContinentName">Continent name</param>
/// <param name="CountryCode">Country code</param>
/// <param name="CountryName">Name of the country</param>
/// <param name="LocalTime">Local time</param>
/// <param name="LocalTimeEpoch">Local time epoch</param>
/// <param name="IsEu">True if the country is part of the EU, otherwise false</param>
/// <param name="GeoNameId">Geoname ID</param>
/// <param name="City">City name</param>
/// <param name="Region">Region name</param>
/// <param name="Lat">Latitude in decimal degree</param>
/// <param name="Lon">Longitude in decimal degree</param>
/// <param name="TzId">Time zone</param>
public sealed record IpLocationResponse(
    [property: JsonPropertyName("ip")] string Ip,
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("continent_code")] string ContinentCode,
    [property: JsonPropertyName("continent_name")] string ContinentName,
    [property: JsonPropertyName("country_code")] string CountryCode,
    [property: JsonPropertyName("country_name")] string CountryName,
    [property: JsonPropertyName("localtime")] string LocalTime,
    [property: JsonPropertyName("localtime_epoch")] int LocalTimeEpoch,
    [property: JsonPropertyName("is_eu"), JsonConverter(typeof(JsonStringToBooleanConverter))]
    bool IsEu,
    [property: JsonPropertyName("geoname_id")] int GeoNameId,
    [property: JsonPropertyName("city")] string City,
    [property: JsonPropertyName("region")] string Region,
    [property: JsonPropertyName("lat")] decimal Lat,
    [property: JsonPropertyName("lon")] decimal Lon,
    [property: JsonPropertyName("tz_id")] string TzId);