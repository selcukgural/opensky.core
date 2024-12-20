using System.Net;
using System.Text.Json;
using System.Web;
using System.Xml.Serialization;
using OSS.Core.Configuration;
using OSS.Core.Model;
using OSS.Core.Response;
using OSS.Core.Service.Internal;

// ReSharper disable InconsistentNaming

namespace OSS.Core.Service;

/// <summary>
/// Represents a service for interacting with the OpenSky API.
/// </summary>
public sealed class OpenSkyService : IOpenSkyService
{
    private readonly HttpClient _httpClient;
    private readonly OssConfiguration _ossConfiguration;

    /// <summary>
    /// Initializes a new instance of the <see cref="OpenSkyService"/> class with the specified HttpClient, ApiConfiguration, and optional OpenSkyServiceOption.
    /// </summary>
    /// <param name="httpClient">The HttpClient to be used for making HTTP requests.</param>
    /// <param name="ossConfiguration">The configuration settings for the API.</param>
    public OpenSkyService(HttpClient httpClient, OssConfiguration ossConfiguration)
    {
        _httpClient = httpClient;
        _ossConfiguration = ossConfiguration;
    }

    /// <inheritdoc />
    public Task<Result<SportResponse>> GetSportsAsync(string q, CancellationToken cancellationToken = default)
    {
        return ExecuteRequestAsync<SportResponse>(QueryParams.Create(ParamName.Q, q), Resource.Sport.Json, ReturnFormat.Entity,
                                                  cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<string>> GetSportsJsonAsync(string q, CancellationToken cancellationToken = default)
    {
        return ExecuteRequestAsync<string>(QueryParams.Create(ParamName.Q, q), Resource.Sport.Json, ReturnFormat.Json,
                                           cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<string>> GetSportsXmlAsync(string q, CancellationToken cancellationToken = default)
    {
        return ExecuteRequestAsync<string>(QueryParams.Create(ParamName.Q, q), Resource.Sport.Xml, ReturnFormat.Xml,
                                           cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<CurrentResponse>> GetCurrentAsync(string q, IncludeAqi? aqi = null, Lang? lang = null,
                                                         CancellationToken cancellationToken = default)
    {
        var queryParam = QueryParams.Create(ParamName.Q, q)
                                    .AddIfNotNull(ParamName.Lang, lang?.ToString())
                                    .AddIfNotNull(ParamName.Aqi, aqi?.ToString());

        return ExecuteRequestAsync<CurrentResponse>(queryParam, Resource.Current.Json, ReturnFormat.Entity, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<string>> GetCurrentJsonAsync(string q, IncludeAqi? aqi = null, Lang? lang = null,
                                                    CancellationToken cancellationToken = default)
    {
        var queryParam = QueryParams.Create(ParamName.Q, q)
                                    .AddIfNotNull(ParamName.Lang, lang?.ToString())
                                    .AddIfNotNull(ParamName.Aqi, aqi?.ToString());

        return ExecuteRequestAsync<string>(queryParam, Resource.Current.Json, ReturnFormat.Json, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<string>> GetCurrentXmlAsync(string q, IncludeAqi? aqi = null, Lang? lang = null, CancellationToken cancellationToken = default)
    {
        var queryParam = QueryParams.Create(ParamName.Q, q)
                                    .AddIfNotNull(ParamName.Lang, lang?.ToString())
                                    .AddIfNotNull(ParamName.Aqi, aqi?.ToString());

        return ExecuteRequestAsync<string>(queryParam, Resource.Current.Xml, ReturnFormat.Xml, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<ForecastResponse>> GetForecastAsync(string q, int days = 1, string? dt = null, string? unixdt = null, int? hour = null,
                                                           int? tp = null, IncludeAqi? aqi = null, IncludeAlerts? alerts = null, Lang? lang = null,
                                                           CancellationToken cancellationToken = default)
    {
        var queryParam = QueryParams.Create(ParamName.Q, q)
                                    .Add(ParamName.Days, days.ToString())
                                    .AddIfNotNull(ParamName.Dt, dt)
                                    .AddIfNotNull(ParamName.UnixDt, unixdt)
                                    .AddIfNotNull(ParamName.Hour, hour?.ToString())
                                    .AddIfNotNull(ParamName.Tp, tp?.ToString())
                                    .AddIfNotNull(ParamName.Aqi, aqi?.ToString())
                                    .AddIfNotNull(ParamName.Alerts, alerts?.ToString())
                                    .AddIfNotNull(ParamName.Lang, lang?.ToString());

        return ExecuteRequestAsync<ForecastResponse>(queryParam, Resource.Forecast.Json, ReturnFormat.Entity, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<string>> GetForecastJsonAsync(string q, int days = 1, string? dt = null, string? unixdt = null, int? hour = null,
                                                     int? tp = null, IncludeAqi? aqi = null, IncludeAlerts? alerts = null, Lang? lang = null,
                                                     CancellationToken cancellationToken = default)
    {
        var queryParam = QueryParams.Create(ParamName.Q, q)
                                    .Add(ParamName.Days, days.ToString())
                                    .AddIfNotNull(ParamName.Dt, dt)
                                    .AddIfNotNull(ParamName.UnixDt, unixdt)
                                    .AddIfNotNull(ParamName.Hour, hour?.ToString())
                                    .AddIfNotNull(ParamName.Tp, tp?.ToString())
                                    .AddIfNotNull(ParamName.Aqi, aqi?.ToString())
                                    .AddIfNotNull(ParamName.Alerts, alerts?.ToString())
                                    .AddIfNotNull(ParamName.Lang, lang?.ToString());

        return ExecuteRequestAsync<string>(queryParam, Resource.Forecast.Json, ReturnFormat.Json, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<string>> GetForecastXmlAsync(string q, int days = 1, string? dt = null, string? unixdt = null, int? hour = null,
                                                    int? tp = null, IncludeAqi? aqi = null, IncludeAlerts? alerts = null, Lang? lang = null,
                                                    CancellationToken cancellationToken = default)
    {
        var queryParam = QueryParams.Create(ParamName.Q, q)
                                    .Add(ParamName.Days, days.ToString())
                                    .AddIfNotNull(ParamName.Dt, dt)
                                    .AddIfNotNull(ParamName.UnixDt, unixdt)
                                    .AddIfNotNull(ParamName.Hour, hour?.ToString())
                                    .AddIfNotNull(ParamName.Tp, tp?.ToString())
                                    .AddIfNotNull(ParamName.Aqi, aqi?.ToString())
                                    .AddIfNotNull(ParamName.Alerts, alerts?.ToString())
                                    .AddIfNotNull(ParamName.Lang, lang?.ToString());

        return ExecuteRequestAsync<string>(queryParam, Resource.Forecast.Xml, ReturnFormat.Xml, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<IEnumerable<Search>>> SearchAsync(string q, CancellationToken cancellationToken = default)
    {
        return ExecuteRequestAsync<IEnumerable<Search>>(QueryParams.Create(ParamName.Q, q), Resource.Search.Json, ReturnFormat.Entity,
                                                        cancellationToken: cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<string>> SearchJsonAsync(string q, CancellationToken cancellationToken = default)
    {
        return ExecuteRequestAsync<string>(QueryParams.Create(ParamName.Q, q), Resource.Search.Json, ReturnFormat.Json, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<string>> SearchXmlAsync(string q, CancellationToken cancellationToken = default)
    {
        return ExecuteRequestAsync<string>(QueryParams.Create(ParamName.Q, q), Resource.Search.Xml, ReturnFormat.Xml, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<AlertResponse>> GetAlertsAsync(string q, CancellationToken cancellationToken = default)
    {
        return ExecuteRequestAsync<AlertResponse>(QueryParams.Create(ParamName.Q, q), Resource.Alert.Json, ReturnFormat.Entity, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<string>> GetAlertsJsonAsync(string q, CancellationToken cancellationToken = default)
    {
        return ExecuteRequestAsync<string>(QueryParams.Create(ParamName.Q, q), Resource.Alert.Json, ReturnFormat.Json, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<string>> GetAlertsXmlAsync(string q, CancellationToken cancellationToken = default)
    {
        return ExecuteRequestAsync<string>(QueryParams.Create(ParamName.Q, q), Resource.Alert.Xml, ReturnFormat.Xml, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<FutureResponse>> GetFutureAsync(string q, string? dt = null, Lang? lang = null, CancellationToken cancellationToken = default)
    {
        var queryParam = QueryParams.Create(ParamName.Q, q)
                                    .AddIfNotNull(ParamName.Lang, lang?.ToString())
                                    .AddIfNotNull(ParamName.Dt, dt);

        return ExecuteRequestAsync<FutureResponse>(queryParam, Resource.Future.Json, ReturnFormat.Entity, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<string>> GetFutureJsonAsync(string q, string? dt = null, Lang? lang = null, CancellationToken cancellationToken = default)
    {
        var queryParam = QueryParams.Create(ParamName.Q, q)
                                    .AddIfNotNull(ParamName.Dt, dt)
                                    .AddIfNotNull(ParamName.Lang, lang?.ToString());

        return ExecuteRequestAsync<string>(queryParam, Resource.Future.Json, ReturnFormat.Json, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<string>> GetFutureXmlAsync(string q, string? dt = null, Lang? lang = null, CancellationToken cancellationToken = default)
    {
        var queryParam = QueryParams.Create(ParamName.Q, q)
                                    .AddIfNotNull(ParamName.Dt, dt)
                                    .AddIfNotNull(ParamName.Lang, lang?.ToString());

        return ExecuteRequestAsync<string>(queryParam, Resource.Future.Xml, ReturnFormat.Xml, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<MarineResponse>> GetMarineAsync(string q, int days, string? dt = null, string? unixdt = null, int? hour = null,
                                                       Lang? lang = null, CancellationToken cancellationToken = default)
    {
        var queryParam = QueryParams.Create(ParamName.Q, q)
                                    .Add(ParamName.Days, days.ToString())
                                    .AddIfNotNull(ParamName.Dt, dt)
                                    .AddIfNotNull(ParamName.UnixDt, unixdt)
                                    .AddIfNotNull(ParamName.Hour, hour?.ToString())
                                    .AddIfNotNull(ParamName.Lang, lang?.ToString());

        return ExecuteRequestAsync<MarineResponse>(queryParam, Resource.Marine.Json, ReturnFormat.Entity, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<string>> GetMarineJsonAsync(string q, int days, string? dt = null, string? unixdt = null, int? hour = null, Lang? lang = null,
                                                   CancellationToken cancellationToken = default)
    {
        var queryParam = QueryParams.Create(ParamName.Q, q)
                                    .Add(ParamName.Days, days.ToString())
                                    .AddIfNotNull(ParamName.Dt, dt)
                                    .AddIfNotNull(ParamName.UnixDt, unixdt)
                                    .AddIfNotNull(ParamName.Hour, hour?.ToString())
                                    .AddIfNotNull(ParamName.Lang, lang?.ToString());

        return ExecuteRequestAsync<string>(queryParam, Resource.Marine.Json, ReturnFormat.Json, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<string>> GetMarineXmlAsync(string q, int days, string? dt = null, string? unixdt = null, int? hour = null, Lang? lang = null,
                                                  CancellationToken cancellationToken = default)
    {
        var queryParam = QueryParams.Create(ParamName.Q, q)
                                    .Add(ParamName.Days, days.ToString())
                                    .AddIfNotNull(ParamName.Dt, dt)
                                    .AddIfNotNull(ParamName.UnixDt, unixdt)
                                    .AddIfNotNull(ParamName.Hour, hour?.ToString())
                                    .AddIfNotNull(ParamName.Lang, lang?.ToString());

        return ExecuteRequestAsync<string>(queryParam, Resource.Marine.Xml, ReturnFormat.Xml, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<AstronomyResponse>> GetAstronomyAsync(string q, string dt, CancellationToken cancellationToken = default)
    {
        return ExecuteRequestAsync<AstronomyResponse>(QueryParams.Create(ParamName.Q, q).Add(ParamName.Dt, dt), Resource.Astronomy.Json, ReturnFormat.Entity, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<string>> GetAstronomyJsonAsync(string q, string dt, CancellationToken cancellationToken = default)
    {
        return ExecuteRequestAsync<string>(QueryParams.Create(ParamName.Q, q).Add(ParamName.Dt, dt), Resource.Astronomy.Json, ReturnFormat.Json, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<string>> GetAstronomyXmlAsync(string q, string dt, CancellationToken cancellationToken = default)
    {
        return ExecuteRequestAsync<string>(QueryParams.Create(ParamName.Q, q).Add(ParamName.Dt, dt), Resource.Astronomy.Xml, ReturnFormat.Xml, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<TimeZoneResponse>> GetTimeZoneAsync(string q, CancellationToken cancellationToken = default)
    {
        return ExecuteRequestAsync<TimeZoneResponse>(QueryParams.Create(ParamName.Q, q), Resource.TimeZone.Json, ReturnFormat.Entity,
                                                     cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<string>> GetTimeZoneJsonAsync(string q, CancellationToken cancellationToken = default)
    {
        return ExecuteRequestAsync<string>(QueryParams.Create(ParamName.Q, q), Resource.TimeZone.Json, ReturnFormat.Json, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<string>> GetTimeZoneXmlAsync(string q, CancellationToken cancellationToken = default)
    {
        return ExecuteRequestAsync<string>(QueryParams.Create(ParamName.Q, q), Resource.TimeZone.Xml, ReturnFormat.Xml, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<IpLocationResponse>> GetIpLocationAsync(string q, CancellationToken cancellationToken = default)
    {
        return ExecuteRequestAsync<IpLocationResponse>(QueryParams.Create(ParamName.Q, q), Resource.IpLocation.Json, ReturnFormat.Entity, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<string>> GetIpLocationJsonAsync(string q, CancellationToken cancellationToken = default)
    {
        return ExecuteRequestAsync<string>(QueryParams.Create(ParamName.Q, q), Resource.IpLocation.Json, ReturnFormat.Json, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<string>> GetIpLocationXmlAsync(string q, CancellationToken cancellationToken = default)
    {
        return ExecuteRequestAsync<string>(QueryParams.Create(ParamName.Q, q), Resource.IpLocation.Xml, ReturnFormat.Xml, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<ForecastResponse>> GetHistoryAsync(string q, string dt, string? unixdt = null, string? end_dt = null,
                                                          string? unixend_dt = null, int? hour = null, Lang? lang = null,
                                                          CancellationToken cancellationToken = default)
    {
        var queryParam = QueryParams.Create(ParamName.Q, q)
                                    .Add(ParamName.Dt, dt)
                                    .AddIfNotNull(ParamName.UnixDt, unixdt)
                                    .AddIfNotNull(ParamName.EndDt, end_dt)
                                    .AddIfNotNull(ParamName.UnixEndDt, unixend_dt)
                                    .AddIfNotNull(ParamName.Hour, hour?.ToString())
                                    .AddIfNotNull(ParamName.Lang, lang?.ToString());

        return ExecuteRequestAsync<ForecastResponse>(queryParam, Resource.History.Json, ReturnFormat.Entity, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<string>> GetHistoryJsonAsync(string q, string dt, string? unixdt = null, string? end_dt = null, string? unixend_dt = null,
                                                    int? hour = null, Lang? lang = null, CancellationToken cancellationToken = default)
    {
        var queryParam = QueryParams.Create(ParamName.Q, q)
                                    .Add(ParamName.Dt, dt)
                                    .AddIfNotNull(ParamName.UnixDt, unixdt)
                                    .AddIfNotNull(ParamName.EndDt, end_dt)
                                    .AddIfNotNull(ParamName.UnixEndDt, unixend_dt)
                                    .AddIfNotNull(ParamName.Hour, hour?.ToString())
                                    .AddIfNotNull(ParamName.Lang, lang?.ToString());

        return ExecuteRequestAsync<string>(queryParam, Resource.History.Json, ReturnFormat.Json, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Result<string>> GetHistoryXmlAsync(string q, string dt, string? unixdt = null, string? end_dt = null, string? unixend_dt = null,
                                                   int? hour = null, Lang? lang = null, CancellationToken cancellationToken = default)
    {
        var queryParam = QueryParams.Create(ParamName.Q, q)
                                    .Add(ParamName.Dt, dt)
                                    .AddIfNotNull(ParamName.UnixDt, unixdt)
                                    .AddIfNotNull(ParamName.EndDt, end_dt)
                                    .AddIfNotNull(ParamName.UnixEndDt, unixend_dt)
                                    .AddIfNotNull(ParamName.Hour, hour?.ToString())
                                    .AddIfNotNull(ParamName.Lang, lang?.ToString());

        return ExecuteRequestAsync<string>(queryParam, Resource.History.Xml, ReturnFormat.Xml, cancellationToken);
    }

    #region private methods

    /// <summary>
    /// Builds a query string for the specified response type and query parameters.
    /// </summary>
    /// <param name="q">The collection of query parameters.</param>
    /// <param name="source">The source endpoint for the request.</param>
    /// <returns>The constructed query string.</returns>
    private string BuildQueryString(QueryParams q, string source)
    {
        var query = HttpUtility.ParseQueryString(string.Concat(_httpClient.BaseAddress, "/", source, "?", $"key={_ossConfiguration.ApiKey}"));

        foreach (var (key, value) in q)
        {
            query[key] = value;
        }

        return Uri.UnescapeDataString(query.ToString()!);
    }

    /// <summary>
    /// Executes an HTTP request asynchronously and returns the result.
    /// </summary>
    /// <typeparam name="TResult">The type of the result.</typeparam>
    /// <param name="q">The collection of query parameters.</param>
    /// <param name="source">The source endpoint for the request.</param>
    /// <param name="format">The format in which the response should be returned.</param>
    /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains a <see cref="Result{TResult}"/> object.
    /// </returns>
    private async Task<Result<TResult>> ExecuteRequestAsync<TResult>(QueryParams q, string source, ReturnFormat format,
                                                                     CancellationToken cancellationToken = default)
    {
        try
        {
            var queryString = BuildQueryString(q, source);
            var httpResponseMessage = await _httpClient.PostAsync(queryString, null, cancellationToken);
            var response = await httpResponseMessage.Content.ReadAsStringAsync(cancellationToken);

            return format switch
            {
                ReturnFormat.Entity => HandleEntityResponse<TResult>(httpResponseMessage, response),
                ReturnFormat.Json   => HandleJsonResponse<TResult>(httpResponseMessage, response),
                ReturnFormat.Xml    => HandleXmlResponse<TResult>(httpResponseMessage, response),
                _                   => throw new ArgumentException("Invalid return format.", nameof(format))
            };
        }
        catch (Exception e)
        {
            return Result<TResult>.Failure(new Error { Message = e.Message, Code = 500, StatusCode = HttpStatusCode.InternalServerError });
        }
    }

    /// <summary>
    /// Handles the entity response from an HTTP request and returns the result.
    /// </summary>
    /// <typeparam name="TResult">The type of the result.</typeparam>
    /// <param name="message">The HTTP response message.</param>
    /// <param name="response">The response content as a string.</param>
    /// <returns>
    /// A <see cref="Result{TResult}"/> object containing the deserialized result or an error.
    /// </returns>
    private static Result<TResult> HandleEntityResponse<TResult>(HttpResponseMessage message, string response)
    {
        return message.StatusCode switch
        {
            HttpStatusCode.OK => Result<TResult>.Success(JsonSerializer.Deserialize<TResult>(response)!),
            _                 => Result<TResult>.Failure(JsonSerializer.Deserialize<ErrorResponse>(response)!.Error)
        };
    }

    /// <summary>
    /// Handles the JSON response from an HTTP request and returns the result.
    /// </summary>
    /// <typeparam name="TResult">The type of the result.</typeparam>
    /// <param name="message">The HTTP response message.</param>
    /// <param name="response">The response content as a string.</param>
    /// <returns>
    /// A <see cref="Result{TResult}"/> object containing the deserialized result or an error.
    /// </returns>
    private static Result<TResult> HandleJsonResponse<TResult>(HttpResponseMessage message, string response)
    {
        return message.StatusCode switch
        {
            HttpStatusCode.OK => Result<TResult>.Success((TResult)Convert.ChangeType(response, typeof(TResult))),
            _                 => Result<TResult>.Failure(JsonSerializer.Deserialize<ErrorResponse>(response)!.Error)
        };
    }

    /// <summary>
    /// Handles the XML response from an HTTP request and returns the result.
    /// </summary>
    /// <typeparam name="TResult">The type of the result.</typeparam>
    /// <param name="message">The HTTP response message.</param>
    /// <param name="response">The response content as a string.</param>
    /// <returns>
    /// A <see cref="Result{TResult}"/> object containing the deserialized result or an error.
    /// </returns>
    private static Result<TResult> HandleXmlResponse<TResult>(HttpResponseMessage message, string response)
    {
        return message.StatusCode switch
        {
            HttpStatusCode.OK => Result<TResult>.Success((TResult)Convert.ChangeType(response, typeof(TResult))),
            _                 => Result<TResult>.Failure(DeserializeError())
        };

        Error DeserializeError()
        {
            var serializer = new XmlSerializer(typeof(Error));
            using var reader = new StringReader(response);
            var error = (Error)serializer.Deserialize(reader)!;
            error.StatusCode = message.StatusCode;
            return error;
        }
    }

    #endregion
}