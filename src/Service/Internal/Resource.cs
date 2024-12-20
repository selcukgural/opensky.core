namespace OSS.Core.Service.Internal;

/// <summary>
/// Represents the base class for resources with XML and JSON properties.
/// </summary>
internal abstract class BaseResource
{
    /// <summary>
    /// Gets or sets the XML representation of the resource.
    /// </summary>
    public abstract string Xml { get; }

    /// <summary>
    /// Gets or sets the JSON representation of the resource.
    /// </summary>
    public abstract string Json { get; }
}

/// <summary>
/// Provides static instances of various resource sources.
/// </summary>
internal static class Resource
{
    /// <summary>
    /// Gets the alert resource source.
    /// </summary>
    public static readonly AlertSource Alert = new();

    /// <summary>
    /// Gets the astronomy resource source.
    /// </summary>
    public static readonly AstronomySource Astronomy = new();

    /// <summary>
    /// Gets the current resource source.
    /// </summary>
    public static readonly CurrentSource Current = new();

    /// <summary>
    /// Gets the forecast resource source.
    /// </summary>
    public static readonly ForecastSource Forecast = new();

    /// <summary>
    /// Gets the future resource source.
    /// </summary>
    public static readonly FutureSource Future = new();

    /// <summary>
    /// Gets the marine resource source.
    /// </summary>
    public static readonly MarineSource Marine = new();

    /// <summary>
    /// Gets the IP location resource source.
    /// </summary>
    public static readonly IpLocationSource IpLocation = new();

    /// <summary>
    /// Gets the sport resource source.
    /// </summary>
    public static readonly SportSource Sport = new();

    /// <summary>
    /// Gets the time zone resource source.
    /// </summary>
    public static readonly TimeZoneSource TimeZone = new();

    /// <summary>
    /// Gets the search resource source.
    /// </summary>
    public static readonly SearchSource Search = new();

    /// <summary>
    /// Gets the history resource source.
    /// </summary>
    public static readonly HistorySource History = new();
}

/// <summary>
/// Represents the history resource source.
/// </summary>
internal sealed class HistorySource : BaseResource
{
    /// <inheritdoc/>
    public override string Xml => "history.xml";

    /// <inheritdoc/>
    public override string Json => "history.json";
}

/// <summary>
/// Represents the search resource source.
/// </summary>
internal sealed class SearchSource : BaseResource
{
    /// <inheritdoc/>
    public override string Xml => "search.xml";

    /// <inheritdoc/>
    public override string Json => "search.json";
}

/// <summary>
/// Represents the time zone resource source.
/// </summary>
internal sealed class TimeZoneSource : BaseResource
{
    /// <inheritdoc/>
    public override string Xml => "timezone.xml";

    /// <inheritdoc/>
    public override string Json => "timezone.json";
}

/// <summary>
/// Represents the sport resource source.
/// </summary>
internal sealed class SportSource : BaseResource
{
    /// <inheritdoc/>
    public override string Xml => "sports.xml";

    /// <inheritdoc/>
    public override string Json => "sports.json";
}

/// <summary>
/// Represents the IP location resource source.
/// </summary>
internal sealed class IpLocationSource : BaseResource
{
    /// <inheritdoc/>
    public override string Xml => "ip.xml";

    /// <inheritdoc/>
    public override string Json => "ip.json";
}

/// <summary>
/// Represents the marine resource source.
/// </summary>
internal sealed class MarineSource : BaseResource
{
    /// <inheritdoc/>
    public override string Xml => "marine.xml";

    /// <inheritdoc/>
    public override string Json => "marine.json";
}

/// <summary>
/// Represents the future resource source.
/// </summary>
internal sealed class FutureSource : BaseResource
{
    /// <inheritdoc/>
    public override string Xml => "future.xml";

    /// <inheritdoc/>
    public override string Json => "future.json";
}

/// <summary>
/// Represents the forecast resource source.
/// </summary>
internal sealed class ForecastSource : BaseResource
{
    /// <inheritdoc/>
    public override string Xml => "forecast.xml";

    /// <inheritdoc/>
    public override string Json => "forecast.json";
}

/// <summary>
/// Represents the current resource source.
/// </summary>
internal sealed class CurrentSource : BaseResource
{
    /// <inheritdoc/>
    public override string Xml => "current.xml";

    /// <inheritdoc/>
    public override string Json => "current.json";
}

/// <summary>
/// Represents the astronomy resource source.
/// </summary>
internal sealed class AstronomySource : BaseResource
{
    /// <inheritdoc/>
    public override string Xml => "astronomy.xml";

    /// <inheritdoc/>
    public override string Json => "astronomy.json";
}

/// <summary>
/// Represents the alert resource source.
/// </summary>
internal sealed class AlertSource : BaseResource
{
    /// <inheritdoc/>
    public override string Xml => "alerts.xml";

    /// <inheritdoc/>
    public override string Json => "alerts.json";
}