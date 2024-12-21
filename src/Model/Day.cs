using System.Text.Json.Serialization;

namespace OpenSky.Core.Model;

/// <summary>
/// Represents the weather data for a day.
/// </summary>
/// <param name="MaxtempC">The maximum temperature in Celsius.</param>
/// <param name="MaxtempF">The maximum temperature in Fahrenheit.</param>
/// <param name="MintempC">The minimum temperature in Celsius.</param>
/// <param name="MintempF">The minimum temperature in Fahrenheit.</param>
/// <param name="AvgtempC">The average temperature in Celsius.</param>
/// <param name="AvgtempF">The average temperature in Fahrenheit.</param>
/// <param name="MaxwindMph">The maximum wind speed in miles per hour.</param>
/// <param name="MaxwindKph">The maximum wind speed in kilometers per hour.</param>
/// <param name="TotalprecipMm">The total precipitation in millimeters.</param>
/// <param name="TotalprecipIn">The total precipitation in inches.</param>
/// <param name="TotalsnowCm">The total snowfall in centimeters.</param>
/// <param name="AvgvisKm">The average visibility in kilometers.</param>
/// <param name="AvgvisMiles">The average visibility in miles.</param>
/// <param name="Avghumidity">The average humidity percentage.</param>
/// <param name="Tides">The list of tides for the day.</param>
/// <param name="DailyWillItRain">Indicates whether it will rain (1) or not (0).</param>
/// <param name="DailyChanceOfRain">The chance of rain as a percentage.</param>
/// <param name="DailyWillItSnow">Indicates whether it will snow (1) or not (0).</param>
/// <param name="DailyChanceOfSnow">The chance of snow as a percentage.</param>
/// <param name="Condition">The weather condition.</param>
/// <param name="Uv">The UV index.</param>
/// <param name="AirQuality">The air quality information.</param>
public sealed record Day(
    [property: JsonPropertyName("maxtemp_c")] decimal MaxtempC,
    [property: JsonPropertyName("maxtemp_f")] decimal MaxtempF,
    [property: JsonPropertyName("mintemp_c")] decimal MintempC,
    [property: JsonPropertyName("mintemp_f")] decimal MintempF,
    [property: JsonPropertyName("avgtemp_c")] decimal AvgtempC,
    [property: JsonPropertyName("avgtemp_f")] decimal AvgtempF,
    [property: JsonPropertyName("maxwind_mph")] decimal MaxwindMph,
    [property: JsonPropertyName("maxwind_kph")] decimal MaxwindKph,
    [property: JsonPropertyName("totalprecip_mm")] decimal TotalprecipMm,
    [property: JsonPropertyName("totalprecip_in")] decimal TotalprecipIn,
    [property: JsonPropertyName("totalsnow_cm")] decimal TotalsnowCm,
    [property: JsonPropertyName("avgvis_km")] decimal AvgvisKm,
    [property: JsonPropertyName("avgvis_miles")] decimal AvgvisMiles,
    [property: JsonPropertyName("avghumidity")] decimal Avghumidity,
    [property: JsonPropertyName("tides")] IReadOnlyList<Tide> Tides,
    [property: JsonPropertyName("daily_will_it_rain")] int DailyWillItRain,
    [property: JsonPropertyName("daily_chance_of_rain")]
    int DailyChanceOfRain,
    [property: JsonPropertyName("daily_will_it_snow")] int DailyWillItSnow,
    [property: JsonPropertyName("daily_chance_of_snow")]
    int DailyChanceOfSnow,
    [property: JsonPropertyName("condition")] Condition Condition,
    [property: JsonPropertyName("uv")] decimal Uv,
    [property: JsonPropertyName("air_quality")] AirQuality AirQuality);