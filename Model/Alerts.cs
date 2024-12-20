using System.Text.Json.Serialization;

namespace OSS.Core.Model;


/// <summary>
/// Represents a collection of alerts.
/// </summary>
/// <param name="Alert">A list of alert objects.</param>
public sealed record Alerts(
    [property: JsonPropertyName("alert")] IReadOnlyList<Alert> Alert
);