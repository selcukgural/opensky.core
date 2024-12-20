using System.Text.Json.Serialization;

namespace OSS.Core.Response;

/// <summary>
/// Represents the response containing sport information.
/// </summary>
/// <param name="Football">The list of football sport information.</param>
/// <param name="Cricket">The list of cricket sport information.</param>
/// <param name="Golf">The list of golf sport information.</param>
public sealed record SportResponse(
    [property: JsonPropertyName("football")] IReadOnlyList<Sport> Football,
    [property: JsonPropertyName("cricket")] IReadOnlyList<Sport> Cricket,
    [property: JsonPropertyName("golf")] IReadOnlyList<Sport> Golf);

/// <summary>
/// Represents sport information.
/// </summary>
/// <param name="Stadium">The stadium where the sport event is held.</param>
/// <param name="Country">The country where the sport event is held.</param>
/// <param name="Region">The region where the sport event is held.</param>
/// <param name="Tournament">The tournament name of the sport event.</param>
/// <param name="Start">The start time of the sport event.</param>
/// <param name="Match">The match details of the sport event.</param>
public sealed record Sport(
    [property: JsonPropertyName("stadium")] string Stadium,
    [property: JsonPropertyName("country")] string Country,
    [property: JsonPropertyName("region")] string Region,
    [property: JsonPropertyName("tournament")] string Tournament,
    [property: JsonPropertyName("start")] string Start,
    [property: JsonPropertyName("match")] string Match);