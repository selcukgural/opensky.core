using System.Text.Json.Serialization;

namespace OpenSky.Core.Model;

/// <summary>
/// Forecast API and Alerts API returns alerts and warnings issued by government agencies (USA, UK, Europe and Rest of the World) as an array if available for the location provided through the Forecast API and Alerts API.
/// By default, alerts are not returned. To get alerts back in the response from Forecast API, pass the parameter alerts=yes.
/// </summary>
/// <param name="Headline">The headline of the alert.</param>
/// <param name="Msgtype">The type of message for the alert.</param>
/// <param name="Severity">The severity level of the alert.</param>
/// <param name="Urgency">The urgency level of the alert.</param>
/// <param name="Areas">The areas affected by the alert.</param>
/// <param name="Category">The category of the alert.</param>
/// <param name="Certainty">The certainty level of the alert.</param>
/// <param name="Event">The event associated with the alert.</param>
/// <param name="Note">Additional notes regarding the alert.</param>
/// <param name="Effective">The date and time when the alert becomes effective.</param>
/// <param name="Expires">The date and time when the alert expires.</param>
/// <param name="Desc">The description of the alert.</param>
/// <param name="Instruction">Instructions related to the alert.</param>
public sealed record Alert(
    [property: JsonPropertyName("headline")] string Headline,
    [property: JsonPropertyName("msgtype")] string Msgtype,
    [property: JsonPropertyName("severity")] string Severity,
    [property: JsonPropertyName("urgency")] string Urgency,
    [property: JsonPropertyName("areas")] string Areas,
    [property: JsonPropertyName("category")] string Category,
    [property: JsonPropertyName("certainty")] string Certainty,
    [property: JsonPropertyName("event")] string Event,
    [property: JsonPropertyName("note")] string Note,
    [property: JsonPropertyName("effective")] DateTime Effective,
    [property: JsonPropertyName("expires")] DateTime Expires,
    [property: JsonPropertyName("desc")] string Desc,
    [property: JsonPropertyName("instruction")] string Instruction);