using System.Text.Json.Serialization;

namespace OpenSky.Core.Model;

/// <summary>
/// Represents astronomical data.
/// </summary>
/// <param name="Astro">The astronomical data.<seealso cref="Astro"/></param>
public sealed record Astronomy(
    [property: JsonPropertyName("astro")] Astro Astro
);