## OpenSky.Core

**OpenSky.Core** is a comprehensive .NET library designed for seamless interaction with the [WeatherAPI.com](https://www.weatherapi.com/) APIs. This library wraps the WeatherAPI functionalities in C#, providing developers with an intuitive and efficient way to integrate weather data into their applications.

### Key Features

- **WeatherAPI Integration**: Leverages the powerful APIs provided by WeatherAPI.com for accessing a wide range of weather data.
- **Strong Typing**: Ensures robust type safety, minimizing runtime errors and enhancing code reliability.
- **Flexible Response Formats**: Supports both XML and JSON response formats, allowing developers to choose the most suitable format for their needs.
- **Error Handling**: Implements comprehensive error handling mechanisms, ensuring that developers can effectively manage and respond to any issues that arise during API interactions.

This project is an excellent tool for developers looking to integrate weather data into their applications with ease and reliability.

### Installation

[Nuget Package](https://www.nuget.org/packages/OpenSky.Core/)

.NET CLI:
```bash
  dotnet add package OpenSky.Core --version 1.0.1
```
Package Manager
```bash
  Install-Package OpenSky.Core -Version 1.0.1
```
Also, you can use [OpenSky.AspNetCore](https://github.com/selcukgural/opensky.aspnetcore) package for your web projects.

### Example Usage

Here is an example of how to use the `OpenSkyService` to search for a location. This example demonstrates how to configure the service and make a request to search for a location.

```csharp
using OpenSky.Core.Configuration;
using OpenSky.Core.Service;

// Create the configuration settings with the API key
var ossConfig = new OssConfiguration { ApiKey = "your-api-key" };

// Create the HttpClient instance
var httpClient = new HttpClient();

// Create the OpenSkyService instance with the HttpClient and configuration settings
var ossService = new OpenSkyService(httpClient, ossConfig);

// Make a request to search for a location
// You can get the return value as strong type, json or xml if you wish.
var result = await ossService.SearchAsync("Ista");
//var jsonResult = await ossService.SearchJsonAsync("Ista");
//var xmlResult = await ossService.SearchXmlAsync("Ista");

// Handle the response (example)
if (result.IsSuccess)
{
    var searchResults = result.Response;
    // Process search results
}
else
{
    Console.WriteLine($"Error: {result.Error!.Message}");
}
```

### License

This project is licensed under the GPL-3.0 License - see the [LICENSE](https://www.gnu.org/licenses/gpl-3.0.html) file for details.

### Contributions

Contributions are welcome! Please fork this repository and submit a pull request with your changes. For major changes, please open an issue first to discuss what you would like to change.
