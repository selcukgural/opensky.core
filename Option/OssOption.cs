namespace OSS.Core.Option;

/// <summary>
/// Represents the options for the OpenSky service.
/// </summary>
public sealed class OssOption
{
    /// <summary>
    /// Gets or sets the timeout duration for the OpenSky service.
    /// </summary>
    public TimeSpan Timeout { get; set; }
}