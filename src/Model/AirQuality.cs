
using System.Text.Json.Serialization;

namespace OpenSky.Core.Model;

/// <summary>
/// Air Quality data is returned in the Forecast API, History API and Realtime API response. 
/// Depending upon your subscription plan we provide historical (from 1st March 2021 onwards), current and 3 day air quality data for the given location in json and xml.
/// 
/// It provides air quality index data on major pollutant gases like Carbon monoxide (CO), Ozone (O3), Nitrogen dioxide (NO2), Sulphur dioxide (SO2), PM 2.5 and PM 10.
/// 
/// By default, air quality data is not returned. To get air quality data back in the response from Forecast API, History API and Realtime API, pass the parameter aqi=yes.
/// </summary>
/// <param name="Co">Carbon Monoxide (μg/m³)</param>
/// <param name="No2">Nitrogen dioxide (μg/m³)</param>
/// <param name="O3">Ozone (μg/m³)</param>
/// <param name="So2">Sulphur dioxide (μg/m³)</param>
/// <param name="Pm25">PM2.5 (μg/m³)</param>
/// <param name="Pm10">PM10 (μg/m³)</param>
/// <param name="UsEpaIndex">
/// US - EPA standard.
/// <list type="number">
/// <item>Means Good</item>
/// <item>Means Moderate</item>
/// <item>Means Unhealthy for sensitive group</item>
/// <item>Means Unhealthy</item>
/// <item>Means Very Unhealthy</item>
/// <item>Means Hazardous</item>
/// </list>
/// </param>
/// <param name="GbDefraIndex">
/// UK Defra Index.
/// <remarks> The following table provides the DEFRA index values, corresponding bands, and concentration ranges (µgm-3): <list type="bullet">
/// <item>
/// <description><b>Index 1</b><br/><b>Band:</b> Low<br/><b>µgm-3:</b> 0-11</description>
/// </item>
/// <item>
/// <description><b>Index 2</b><br/><b>Band:</b> Low<br/><b>µgm-3:</b> 12-23</description>
/// </item>
/// <item><description><b>Index 3</b><br/><b>Band:</b> Low<br/><b>µgm-3:</b> 24-35</description>
/// </item>
/// <item>
/// <description><b>Index 4</b><br/><b>Band:</b> Moderate<br/><b>µgm-3:</b> 36-41</description>
/// </item>
/// <item>
/// <description><b>Index 5</b><br/><b>Band:</b> Moderate<br/><b>µgm-3:</b> 42-47</description>
/// </item>
/// <item>
/// <description><b>Index 6</b><br/><b>Band:</b> Moderate<br/><b>µgm-3:</b> 48-53</description>
/// </item>
/// <item>
/// <description><b>Index 7</b><br/><b>Band:</b> High<br/><b>µgm-3:</b> 54-58</description>
/// </item>
/// <item>
/// <description><b>Index 8</b><br/><b>Band:</b> High<br/><b>µgm-3:</b> 59-64</description>
/// </item> /// <item>
/// <description><b>Index 9</b><br/><b>Band:</b> High<br/><b>µgm-3:</b> 65-70</description>
/// </item>
/// <item>
/// <description><b>Index 10</b><br/><b>Band:</b> Very High<br/><b>µgm-3:</b> 71 or more</description>
/// </item>
/// </list>
/// </remarks>
/// </param>
public sealed record AirQuality(
    [property: JsonPropertyName("co")] decimal Co,
    [property: JsonPropertyName("no2")] decimal No2,
    [property: JsonPropertyName("o3")] decimal O3,
    [property: JsonPropertyName("so2")] decimal So2,
    [property: JsonPropertyName("pm2_5")] decimal Pm25,
    [property: JsonPropertyName("pm10")] decimal Pm10,
    [property: JsonPropertyName("us-epa-index")] int UsEpaIndex,
    [property: JsonPropertyName("gb-defra-index")] int GbDefraIndex);