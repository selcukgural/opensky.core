using System.Text.Json.Serialization;

namespace OpenSky.Core.Model;

/// <summary>
/// Represents astronomical data including sunrise, sunset, moonrise, moonset, moon phase, moon illumination, and whether the moon or sun is up.
/// </summary>
/// <param name="Sunrise">Sunrise time.</param>
/// <param name="Sunset">Sunset time.</param>
/// <param name="Moonrise">Moonrise time.</param>
/// <param name="Moonset">Moonset time.</param>
/// <param name="MoonPhase">
/// Moon phases. Value returned:
/// <list type="bullet">
/// <item>New Moon</item>
/// <item>Waxing Crescent</item>
/// <item>First Quarter</item>
/// <item>Waxing Gibbous</item>
/// <item>Full Moon</item>
/// <item>Waning Gibbous</item>
/// <item>Last Quarter</item>
/// <item>Waning Crescent</item>
/// </list>
/// </param>
/// <param name="MoonIllumination">Moon illumination as a percentage.</param>
/// <param name="IsMoonUp">
/// Determine if the moon is currently up, based on moonset and moonrise time at the provided location and date.
/// 1 = Yes, 0 = No.
/// </param>
/// <param name="IsSunUp">
/// Determine if the sun is currently up, based on sunset and sunrise time at the provided location and date.
/// 1 = Yes, 0 = No.
/// </param>
public sealed record Astro(
    [property: JsonPropertyName("sunrise")] string Sunrise,
    [property: JsonPropertyName("sunset")] string Sunset,
    [property: JsonPropertyName("moonrise")] string Moonrise,
    [property: JsonPropertyName("moonset")] string Moonset,
    [property: JsonPropertyName("moon_phase")] string MoonPhase,
    [property: JsonPropertyName("moon_illumination")] decimal MoonIllumination,
    [property: JsonPropertyName("is_moon_up")] int IsMoonUp,
    [property: JsonPropertyName("is_sun_up")] int IsSunUp
);