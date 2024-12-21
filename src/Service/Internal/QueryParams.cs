using System.Collections.Concurrent;

namespace OpenSky.Core.Service.Internal;

/// <summary>
/// Represents a collection of query parameters for HTTP requests.
/// </summary>
internal sealed class QueryParams : ConcurrentDictionary<string, string>
{
    /// <summary>
    /// Adds a key-value pair to the query parameters.
    /// </summary>
    /// <param name="key">The key of the query parameter.</param>
    /// <param name="value">The value of the query parameter.</param>
    /// <returns>The current instance of <see cref="QueryParams"/>.</returns>
    public QueryParams Add(string key, string value)
    {
        ArgumentException.ThrowIfNullOrEmpty(key, nameof(key));
        ArgumentException.ThrowIfNullOrEmpty(value, nameof(value));

        TryAdd(key, value);
        return this;
    }

    /// <summary>
    /// Creates a new instance of <see cref="QueryParams"/> with a single key-value pair.
    /// </summary>
    /// <param name="key">The key of the query parameter.</param>
    /// <param name="value">The value of the query parameter.</param>
    /// <returns>A new instance of <see cref="QueryParams"/>.</returns>
    public static QueryParams Create(string key, string value)
    {
        ArgumentException.ThrowIfNullOrEmpty(key, nameof(key));
        ArgumentException.ThrowIfNullOrEmpty(value, nameof(value));

        var queryParams = new QueryParams
        {
            {
                key, value
            }
        };
        return queryParams;
    }

    /// <summary>
    /// Adds a key-value pair to the query parameters if the value is not null or empty.
    /// </summary>
    /// <param name="key">The key of the query parameter.</param>
    /// <param name="value">The value of the query parameter, or null.</param>
    /// <returns>The current instance of <see cref="QueryParams"/>.</returns>
    public QueryParams AddIfNotNull(string key, string? value)
    {
        return !string.IsNullOrEmpty(value) ? Add(key, value) : this;
    }
}

/// <summary>
/// Contains constant string values representing parameter names for query parameters.
/// </summary>
internal static class ParamName
{
    /// <summary>
    /// Represents the query parameter name for a general query.
    /// </summary>
    public const string Q = "q";

    /// <summary>
    /// Represents the query parameter name for a time period.
    /// </summary>
    public const string Tp = "tp";

    /// <summary>
    /// Represents the query parameter name for the number of days.
    /// </summary>
    public const string Days = "days";

    /// <summary>
    /// Represents the query parameter name for a date.
    /// </summary>
    public const string Dt = "dt";

    /// <summary>
    /// Represents the query parameter name for a Unix timestamp date.
    /// </summary>
    public const string UnixDt = "unixdt";

    /// <summary>
    /// Represents the query parameter name for an hour.
    /// </summary>
    public const string Hour = "hour";

    /// <summary>
    /// Represents the query parameter name for a language.
    /// </summary>
    public const string Lang = "lang";

    /// <summary>
    /// Represents the query parameter name for air quality index.
    /// </summary>
    public const string Aqi = "aqi";

    /// <summary>
    /// Represents the query parameter name for alerts.
    /// </summary>
    public const string Alerts = "alerts";

    /// <summary>
    /// Represents the query parameter name for an end date.
    /// </summary>
    public const string EndDt = "end_dt";

    /// <summary>
    /// Represents the query parameter name for a Unix timestamp end date.
    /// </summary>
    public const string UnixEndDt = "unixend_dt";
}