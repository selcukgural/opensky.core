using OpenSky.Core.Model;
using OpenSky.Core.Response;

// ReSharper disable InconsistentNaming

namespace OpenSky.Core.Service;

public interface IOpenSkyService
{
    /// <summary>
    /// Retrieves sports information based on the provided query.
    /// </summary>
    /// <param name="q">
    /// Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name.
    /// Visit <see href="https://www.weatherapi.com/docs/#intro-request"/> request parameter section to learn more.
    /// </param>
    /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a <see cref="Result{SportResponse}"/> object.</returns>
    public Task<Result<SportResponse>> GetSportsAsync(string q, CancellationToken cancellationToken = default);
    
    /// <inheritdoc cref="GetSportsAsync"/>
    public Task<Result<string>> GetSportsJsonAsync(string q, CancellationToken cancellationToken = default);
    
    /// <inheritdoc cref="GetSportsAsync"/>
    public Task<Result<string>> GetSportsXmlAsync(string q, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves current weather information based on the provided query.
    /// </summary>
    /// <param name="q">
    /// Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name.
    /// Visit <see href="https://www.weatherapi.com/docs/#intro-request"/> request parameter section to learn more.
    /// </param>
    /// <param name="aqi">Include air quality information (Yes or No).</param>
    /// <param name="lang">
    /// Returns 'condition:text' field in API in the desired language.
    /// Visit <see href="https://www.weatherapi.com/docs/#intro-request"/> request parameter section to check 'lang-code'.
    /// </param>
    /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a <see cref="Result{CurrentResponse}"/> object.</returns>
    public Task<Result<CurrentResponse>> GetCurrentAsync(string q, IncludeAqi? aqi = null, Lang? lang = null,
                                                         CancellationToken cancellationToken = default);
    
    /// <inheritdoc cref="GetCurrentAsync"/>
    public Task<Result<string>> GetCurrentJsonAsync(string q, IncludeAqi? aqi = null, Lang? lang = null,CancellationToken cancellationToken = default);
    
    /// <inheritdoc cref="GetCurrentAsync"/>
    public Task<Result<string>> GetCurrentXmlAsync(string q, IncludeAqi? aqi = null, Lang? lang = null,CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves weather forecast data based on the provided query and date parameters.
    /// </summary>
    /// <param name="q">
    /// Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name.
    /// Visit <see href="https://www.weatherapi.com/docs/#intro-request"/> request parameter section to learn more.
    /// </param>
    /// <param name="days">
    /// Number of days of weather forecast. Value ranges from 1 to 14.
    /// Available values: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14.
    /// </param>
    /// <param name="dt">
    /// Date should be between today and next 14 days in yyyy-MM-dd format. e.g., '2015-01-01'.
    /// </param>
    /// <param name="unixdt">
    /// Please either pass 'dt' or 'unixdt' and not both in the same request. unixdt should be between today and next 14 days in Unix format. e.g., 1490227200.
    /// </param>
    /// <param name="hour">
    /// Must be in 24-hour format. For example, 5 pm should be hour=17, 6 am as hour=6.
    /// </param>
    /// <param name="tp">
    /// Get 15 min interval or 24-hour average data for Forecast and History API. Available for Enterprise clients only. e.g., tp=15.
    /// </param>
    /// <param name="aqi">
    /// Enable/Disable Air Quality data in forecast API output. Example, aqi=yes or aqi=no.
    /// </param>
    /// <param name="alerts">
    /// Enable/Disable alerts in forecast API output. Example, alerts=yes or alerts=no.
    /// </param>
    /// <param name="lang">
    /// Returns 'condition:text' field in API in the desired language.
    /// Visit <see href="https://www.weatherapi.com/docs/#intro-request"/> request parameter section to check 'lang-code'.
    /// </param>
    /// <param name="cancellationToken">
    /// Token to monitor for cancellation requests.
    /// </param>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains a <see cref="Result{ForecastResponse}"/> object.
    /// </returns>
    public Task<Result<ForecastResponse>> GetForecastAsync(string q, int days = 1, string? dt = null, string? unixdt = null, int? hour = null,
                                                           int? tp = null, IncludeAqi? aqi = null, IncludeAlerts? alerts = null, Lang? lang = null,
                                                           CancellationToken cancellationToken = default);
    
    /// <inheritdoc cref="GetForecastAsync"/>
    public Task<Result<string>> GetForecastJsonAsync(string q, int days = 1, string? dt = null, string? unixdt = null, int? hour = null,
                                                     int? tp = null, IncludeAqi? aqi = null, IncludeAlerts? alerts = null, Lang? lang = null,
                                                        CancellationToken cancellationToken = default);
    
    /// <inheritdoc cref="GetForecastAsync"/>
    public Task<Result<string>> GetForecastXmlAsync(string q, int days = 1, string? dt = null, string? unixdt = null, int? hour = null,
                                                    int? tp = null, IncludeAqi? aqi = null, IncludeAlerts? alerts = null, Lang? lang = null,
                                                    CancellationToken cancellationToken = default);

    /// <summary>
    /// Searches for locations based on the provided query.
    /// </summary>
    /// <param name="q">
    /// Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name.
    /// Visit <see href="https://www.weatherapi.com/docs/#intro-request"/> request parameter section to learn more.
    /// </param>
    /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a collection of <see cref="Search"/> objects.</returns>
    public Task<Result<IEnumerable<Search>>> SearchAsync(string q, CancellationToken cancellationToken = default);
    
    /// <inheritdoc cref="SearchAsync"/>
    public Task<Result<string>> SearchJsonAsync(string q, CancellationToken cancellationToken = default);
    
    /// <inheritdoc cref="SearchAsync"/>
    public Task<Result<string>> SearchXmlAsync(string q, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves weather alert information based on the provided query.
    /// </summary>
    /// <param name="q">
    /// Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name.
    /// Visit <see href="https://www.weatherapi.com/docs/#intro-request"/> request parameter section to learn more.
    /// </param>
    /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a <see cref="Result{AlertResponse}"/> object.</returns>
    public Task<Result<AlertResponse>> GetAlertsAsync(string q, CancellationToken cancellationToken = default);
    
    /// <inheritdoc cref="GetAlertsAsync"/>
    public Task<Result<string>> GetAlertsJsonAsync(string q, CancellationToken cancellationToken = default);
    
    /// <inheritdoc cref="GetAlertsAsync"/>
    public Task<Result<string>> GetAlertsXmlAsync(string q, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves future weather forecast data based on the provided query and date parameters.
    /// </summary>
    /// <param name="q">
    /// Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name.
    /// Visit <see href="https://www.weatherapi.com/docs/#intro-request"/> request parameter section to learn more.
    /// </param>
    /// <param name="dt">Date should be between 14 days and 300 days from today in the future in yyyy-MM-dd format (i.e. dt=2023-01-01) (optional).</param>
    /// <param name="lang">
    /// Returns 'condition:text' field in API in the desired language.
    /// Visit <see href="https://www.weatherapi.com/docs/#intro-request"/> request parameter section to check 'lang-code'.
    /// </param>
    /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a <see cref="Result{FutureResponse}"/> object.</returns>
    public Task<Result<FutureResponse>> GetFutureAsync(string q, string? dt = null, Lang? lang = null, CancellationToken cancellationToken = default);
    
    /// <inheritdoc cref="GetFutureAsync"/>
    public Task<Result<string>> GetFutureJsonAsync(string q, string? dt = null, Lang? lang = null, CancellationToken cancellationToken = default);
    
    /// <inheritdoc cref="GetMarineAsync"/>
    public Task<Result<string>> GetFutureXmlAsync(string q, string? dt = null, Lang? lang = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves marine weather forecast data based on the provided query and date parameters.
    /// </summary>
    /// <param name="q">
    /// Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name.
    /// Visit <see href="https://www.weatherapi.com/docs/#intro-request"/> request parameter section to learn more.
    /// </param>
    /// <param name="days">Number of days for the forecast.</param>
    /// <param name="dt">Date on or after 1st Jan, 2015 in yyyy-MM-dd (optional) format.</param>
    /// <param name="unixdt">Date in Unix Timestamp format (optional).</param>
    /// <param name="hour">
    /// Must be in 24-hour format. For example, 5 pm should be hour=17, 6 am as hour=6 (optional).
    /// </param>
    /// <param name="lang">
    /// Returns 'condition:text' field in API in the desired language.
    /// Visit <see href="https://www.weatherapi.com/docs/#intro-request"/> request parameter section to check 'lang-code'.
    /// </param>
    /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a <see cref="Result{MarineResponse}"/> object.</returns>
    public Task<Result<MarineResponse>> GetMarineAsync(string q, int days, string? dt = null, string? unixdt = null, int? hour = null, Lang? lang = null,
                                                       CancellationToken cancellationToken = default);
    
    /// <inheritdoc cref="GetMarineAsync"/>
    public Task<Result<string>> GetMarineJsonAsync(string q, int days, string? dt = null, string? unixdt = null, int? hour = null, Lang? lang = null,
                                                   CancellationToken cancellationToken = default);
    
    /// <inheritdoc cref="GetMarineAsync"/>
    public Task<Result<string>> GetMarineXmlAsync(string q, int days, string? dt = null, string? unixdt = null, int? hour = null, Lang? lang = null,
                                                  CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves astronomy information based on the provided query and date parameters.
    /// </summary>
    /// <param name="q">
    /// Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name.
    /// Visit <see href="https://www.weatherapi.com/docs/#intro-request"/> request parameter section to learn more.
    /// </param>
    /// <param name="dt">Date on or after 1st Jan, 2015 in yyyy-MM-dd format.</param>
    /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a <see cref="Result{AstronomyResponse}"/> object.</returns>
    public Task<Result<AstronomyResponse>> GetAstronomyAsync(string q, string dt, CancellationToken cancellationToken = default);
    
    /// <inheritdoc cref="GetAstronomyAsync"/>
    public Task<Result<string>> GetAstronomyJsonAsync(string q, string dt, CancellationToken cancellationToken = default);
    
    /// <inheritdoc cref="GetAstronomyAsync"/>
    public Task<Result<string>> GetAstronomyXmlAsync(string q, string dt, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves time zone information based on the provided query.
    /// </summary>
    /// <param name="q">
    /// Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name.
    /// Visit <see href="https://www.weatherapi.com/docs/#intro-request"/> request parameter section to learn more.
    /// </param>
    /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a <see cref="Result{TimeZoneResponse}"/> object.</returns>
    public Task<Result<TimeZoneResponse>> GetTimeZoneAsync(string q, CancellationToken cancellationToken = default);
    
    /// <inheritdoc cref="GetTimeZoneAsync"/>
    public Task<Result<string>> GetTimeZoneJsonAsync(string q, CancellationToken cancellationToken = default);
    
    /// <inheritdoc cref="GetTimeZoneAsync"/>
    public Task<Result<string>> GetTimeZoneXmlAsync(string q, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves IP location information based on the provided query.
    /// </summary>
    /// <param name="q">
    /// Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name.
    /// Visit <see href="https://www.weatherapi.com/docs/#intro-request"/> request parameter section to learn more.
    /// </param>
    /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a <see cref="Result{IpLocationResponse}"/> object.</returns>
    public Task<Result<IpLocationResponse>> GetIpLocationAsync(string q, CancellationToken cancellationToken = default);
    
    /// <inheritdoc cref="GetIpLocationAsync"/>
    public Task<Result<string>> GetIpLocationJsonAsync(string q, CancellationToken cancellationToken = default);
    
    /// <inheritdoc cref="GetIpLocationAsync"/>
    public Task<Result<string>> GetIpLocationXmlAsync(string q, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves historical weather forecast data based on the provided query and date parameters.
    /// </summary>
    /// <param name="q">
    /// Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name. 
    /// Visit <see href="https://www.weatherapi.com/docs/#intro-request"/> request parameter section to learn more.
    /// </param>
    /// <param name="dt">Date on or after 1st Jan, 2015 in yyyy-MM-dd format.</param>
    /// <param name="unixdt">
    /// Please either pass 'dt' or 'unixdt' and not both in the same request.
    /// unixdt should be on or after 1st Jan, 2015 in Unix format.
    /// </param>
    /// <param name="end_dt">
    /// Date on or after 1st Jan, 2015 in yyyy-MM-dd format. 'end_dt' should be greater than 'dt' parameter and the difference should not be more than 30 days between the two dates.
    /// </param>
    /// <param name="unixend_dt">
    /// Date on or after 1st Jan, 2015 in Unix Timestamp format. unixend_dt has the same restriction as 'end_dt' parameter. 
    /// Please either pass 'end_dt' or 'unixend_dt' and not both in the same request. e.g., unixend_dt=1490227200.
    /// </param>
    /// <param name="hour">
    /// Must be in 24-hour format. For example, 5 pm should be hour=17, 6 am as hour=6.
    /// </param>
    /// <param name="lang">
    /// Returns 'condition:text' field in API in the desired language. 
    /// Visit <see href="https://www.weatherapi.com/docs/#intro-request"/> request parameter section to check 'lang-code'.
    /// </param>
    /// <param name="cancellationToken">Token to monitor for cancellation requests.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a <see cref="Result{ForecastResponse}"/> object.</returns>
    public Task<Result<ForecastResponse>> GetHistoryAsync(string q, string dt, string? unixdt = null, string? end_dt = null, string? unixend_dt = null,
                                                          int? hour = null, Lang? lang = null, CancellationToken cancellationToken = default);
    
    /// <inheritdoc cref="GetHistoryAsync"/>
    public Task<Result<string>> GetHistoryJsonAsync(string q, string dt, string? unixdt = null, string? end_dt = null, string? unixend_dt = null,
                                                    int? hour = null, Lang? lang = null, CancellationToken cancellationToken = default);
    
    /// <inheritdoc cref="GetHistoryAsync"/>
    public Task<Result<string>> GetHistoryXmlAsync(string q, string dt, string? unixdt = null, string? end_dt = null, string? unixend_dt = null,
                                                   int? hour = null, Lang? lang = null, CancellationToken cancellationToken = default);
}