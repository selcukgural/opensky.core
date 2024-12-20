using System.Text.Json.Serialization;

namespace OSS.Core.Model;

/// <summary>
/// Represents the current weather conditions.
/// </summary>
/// <param name="LastUpdatedEpoch">The epoch time of the last update.</param>
/// <param name="LastUpdated">The string representation of the last update time.</param>
/// <param name="TempC">The temperature in Celsius.</param>
/// <param name="TempF">The temperature in Fahrenheit.</param>
/// <param name="IsDay">Indicates whether it is day (1) or night (0).</param>
/// <param name="Condition">The weather condition.</param>
/// <param name="WindMph">The wind speed in miles per hour.</param>
/// <param name="WindKph">The wind speed in kilometers per hour.</param>
/// <param name="WindDegree">The wind direction in degrees.</param>
/// <param name="WindDir">The wind direction as a string.</param>
/// <param name="PressureMb">The atmospheric pressure in millibars.</param>
/// <param name="PressureIn">The atmospheric pressure in inches.</param>
/// <param name="PrecipMm">The precipitation amount in millimeters.</param>
/// <param name="PrecipIn">The precipitation amount in inches.</param>
/// <param name="Humidity">The humidity percentage.</param>
/// <param name="Cloud">The cloud cover percentage.</param>
/// <param name="FeelslikeC">The apparent temperature in Celsius.</param>
/// <param name="FeelslikeF">The apparent temperature in Fahrenheit.</param>
/// <param name="WindchillC">The wind chill temperature in Celsius.</param>
/// <param name="WindchillF">The wind chill temperature in Fahrenheit.</param>
/// <param name="HeatindexC">The heat index temperature in Celsius.</param>
/// <param name="HeatindexF">The heat index temperature in Fahrenheit.</param>
/// <param name="DewpointC">The dew point temperature in Celsius.</param>
/// <param name="DewpointF">The dew point temperature in Fahrenheit.</param>
/// <param name="VisKm">The visibility in kilometers.</param>
/// <param name="VisMiles">The visibility in miles.</param>
/// <param name="Uv">The UV index.</param>
/// <param name="GustMph">The wind gust speed in miles per hour.</param>
/// <param name="GustKph">The wind gust speed in kilometers per hour.</param>
/// <param name="AirQuality">The air quality information.</param>
public sealed record Current(
    [property: JsonPropertyName("last_updated_epoch")] int LastUpdatedEpoch,
    [property: JsonPropertyName("last_updated")] string LastUpdated,
    [property: JsonPropertyName("temp_c")] decimal TempC,
    [property: JsonPropertyName("temp_f")] decimal TempF,
    [property: JsonPropertyName("is_day")] int IsDay,
    [property: JsonPropertyName("condition")] Condition Condition,
    [property: JsonPropertyName("wind_mph")] decimal WindMph,
    [property: JsonPropertyName("wind_kph")] decimal WindKph,
    [property: JsonPropertyName("wind_degree")] int WindDegree,
    [property: JsonPropertyName("wind_dir")] string WindDir,
    [property: JsonPropertyName("pressure_mb")] decimal PressureMb,
    [property: JsonPropertyName("pressure_in")] decimal PressureIn,
    [property: JsonPropertyName("precip_mm")] decimal PrecipMm,
    [property: JsonPropertyName("precip_in")] decimal PrecipIn,
    [property: JsonPropertyName("humidity")] int Humidity,
    [property: JsonPropertyName("cloud")] int Cloud,
    [property: JsonPropertyName("feelslike_c")] decimal FeelslikeC,
    [property: JsonPropertyName("feelslike_f")] decimal FeelslikeF,
    [property: JsonPropertyName("windchill_c")] decimal WindchillC,
    [property: JsonPropertyName("windchill_f")] decimal WindchillF,
    [property: JsonPropertyName("heatindex_c")] decimal HeatindexC,
    [property: JsonPropertyName("heatindex_f")] decimal HeatindexF,
    [property: JsonPropertyName("dewpoint_c")] decimal DewpointC,
    [property: JsonPropertyName("dewpoint_f")] decimal DewpointF,
    [property: JsonPropertyName("vis_km")] decimal VisKm,
    [property: JsonPropertyName("vis_miles")] decimal VisMiles,
    [property: JsonPropertyName("uv")] decimal Uv,
    [property: JsonPropertyName("gust_mph")] decimal GustMph,
    [property: JsonPropertyName("gust_kph")] decimal GustKph,
    [property: JsonPropertyName("air_quality")] AirQuality AirQuality);