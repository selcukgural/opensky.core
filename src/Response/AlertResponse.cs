using System.Text.Json.Serialization;
using OpenSky.Core.Model;

namespace OpenSky.Core.Response;

/// <summary>
/// Represents the response containing alert information.
/// </summary>
/// <param name="Location">The location information.</param>
/// <param name="Alerts">The alerts information.</param>
public sealed record AlertResponse([property: JsonPropertyName("location")] Location Location, [property: JsonPropertyName("alerts")] Alerts Alerts);