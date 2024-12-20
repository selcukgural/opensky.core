using System.Text.Json.Serialization;
using OSS.Core.Model;

namespace OSS.Core.Response;

/// <summary>
/// Represents the response containing time zone information.
/// </summary>
/// <param name="Location">The location information.</param>
public sealed record TimeZoneResponse([property: JsonPropertyName("location")] Location Location);