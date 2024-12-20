using System.ComponentModel;

namespace OSS.Core.Model;

/// <summary>
/// Specifies whether to include air quality information.
/// </summary>
public enum IncludeAqi
{
    /// <summary>
    /// Include air quality information.
    /// </summary>
    [Description("yes")] Yes = 1,

    /// <summary>
    /// Do not include air quality information.
    /// </summary>
    [Description("no")] No = 2
}

/// <summary>
/// Specifies whether to include weather alerts.
/// </summary>
public enum IncludeAlerts
{
    /// <summary>
    /// Include weather alerts.
    /// </summary>
    [Description("yes")] Yes = 1,

    /// <summary>
    /// Do not include weather alerts.
    /// </summary>
    [Description("no")] No = 2
}