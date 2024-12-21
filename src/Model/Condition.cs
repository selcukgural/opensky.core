using System.Text.Json.Serialization;

namespace OpenSky.Core.Model;

/// <summary>
/// Represents a weather condition with text, icon, and code.
/// </summary>
/// <param name="Text">The description of the weather condition.</param>
/// <param name="Icon">The URL of the icon representing the weather condition.</param>
/// <param name="Code">The code representing the weather condition.</param>
public sealed record Condition(
    [property: JsonPropertyName("text")] string Text,
    [property: JsonPropertyName("icon")] string Icon,
    [property: JsonPropertyName("code")] int Code);