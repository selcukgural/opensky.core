using System.Net;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace OpenSky.Core.Response;

/// <summary>
/// API Error Codes.
/// If there is an error, the API response contains an error message including an error code for the following 4xx HTTP Status codes.
/// </summary>
/// <remarks>
/// The following are the possible error codes:
/// <list type="bullet">
/// <item>
/// <description><b>HTTP Status Code 401</b><br/><b>Error code</b>: 1002 - API key not provided.</description>
/// </item>
/// <item>
/// <description><b>HTTP Status Code 400</b><br/><b>Error code</b>: 1003 - Parameter 'q' not provided.</description>
/// </item>
/// <item>
/// <description><b>HTTP Status Code 400</b><br/><b>Error code</b>: 1005 - API request URL is invalid.</description>
/// </item>
/// <item>
/// <description><b>HTTP Status Code 400</b><br/><b>Error code</b>: 1006 - No location found matching parameter 'q'.</description>
/// </item>
/// <item>
/// <description><b>HTTP Status Code 401</b><br/><b>Error code</b>: 2006 - API key provided is invalid.</description>
/// </item>
/// <item>
/// <description><b>HTTP Status Code 403</b><br/><b>Error code</b>: 2007 - API key has exceeded calls per month quota.</description>
/// </item>
/// <item>
/// <description><b>HTTP Status Code 403</b><br/><b>Error code</b>: 2008 - API key has been disabled.</description>
/// </item>
/// <item>
/// <description><b>HTTP Status Code 403</b><br/><b>Error code</b>: 2009 - API key does not have access to the resource. Please check the pricing page for what is allowed in your API subscription plan.</description>
/// </item>
/// <item>
/// <description><b>HTTP Status Code 400</b><br/><b>Error code</b>: 9000 - Json body passed in bulk request is invalid. Please make sure it is valid JSON with UTF-8 encoding.</description>
/// </item>
/// <item>
/// <description><b>HTTP Status Code 400</b><br/><b>Error code</b>: 9001 - Json body contains too many locations for bulk request. Please keep it below 50 in a single request.</description>
/// </item>
/// <item>
/// <description><b>HTTP Status Code 400</b><br/><b>Error code</b>: 9999 - Internal application error.</description>
/// </item>
/// </list>
/// </remarks>
[XmlRoot("error")]
public sealed record Error
{
    /// <summary>
    /// The HTTP status code of the error.
    /// </summary>
    public HttpStatusCode StatusCode { get; set; }

    /// <summary>
    /// The error code.
    /// </summary>
    [JsonPropertyName("code")] [XmlElement("code")]public required int Code { get; set; }

    /// <summary>
    /// The error message.
    /// </summary>
    [JsonPropertyName("message")] [XmlElement("message")]public required string Message { get; set; }
}

/// <summary>
/// Represents the error response containing the error details.
/// </summary>
public sealed record ErrorResponse
{

    /// <inheritdoc cref="Error"/>>
    [JsonPropertyName("error")] [XmlElement("error")]public required Error Error { get; set; }
}