using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OpenSky.Core.Configuration;

/// <summary>
/// Represents the configuration settings for the API.
/// </summary>
public sealed class OssConfiguration
{
    /// <summary>
    /// Gets or sets the API key.
    /// </summary>
    [Required]
    public string ApiKey { get; set; } = null!;

    /// <summary>
    /// Gets or sets the base URL of the API.
    /// </summary>
    [DefaultValue("api.weatherapi.com")]
    public string BaseUrl { get; set; } = "api.weatherapi.com";

    /// <summary>
    /// Gets or sets the version of the API.
    /// </summary>
    [DefaultValue("v1")]
    public string Version { get; set; } = "v1";

    /// <summary>
    /// Gets or sets a value indicating whether to use HTTPS.
    /// </summary>
    [DefaultValue(true)]
    public bool UseHttps { get; set; } = true;

    /// <summary>
    /// Constructs the base URL for the API using the configuration settings.
    /// </summary>
    /// <returns>
    /// A string representing the base URL, including the protocol (http or https), base URL, and version.
    /// </returns>
    internal string GetBaseUrl()
    {
        return $"{(UseHttps ? "https" : "http")}://{BaseUrl}/{Version}";
    }
}