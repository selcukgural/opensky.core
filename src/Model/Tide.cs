using System.Text.Json.Serialization;

namespace OpenSky.Core.Model;

/// <summary>
/// Represents a tide event.
/// </summary>
/// <param name="TideTime">The time of the tide event.</param>
/// <param name="TideHeightMt">The height of the tide in meters.</param>
/// <param name="TideType">The type of the tide (e.g., high, low).</param>
public sealed record Tide(
    [property: JsonPropertyName("tide_time")] string TideTime,
    [property: JsonPropertyName("tide_height_mt")] string TideHeightMt,
    [property: JsonPropertyName("tide_type")] string TideType);