using WeatherWebApp_Model;
using WeatherWebApp_Interface;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
public class OpenWeatherService : IOpenWeatherRepository
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;

    public OpenWeatherService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _apiKey = configuration["OpenWeatherApi:ApiKey"];
    }

    public async Task<string> GetCurrentWeatherByCity(string city)
    {
        var response = await _httpClient.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=metric");
        response.EnsureSuccessStatusCode();
        var data = await response.Content.ReadAsStringAsync();
        return data;
    }

    public async Task<string> Get5DayForecastByCity(string city)
    {
        var response = await _httpClient.GetAsync($"http://api.openweathermap.org/data/2.5/forecast?q={city}&appid={_apiKey}");
        response.EnsureSuccessStatusCode();
        var data = await response.Content.ReadAsStringAsync();
        return data;
    }

    public async Task<string> GetAirQualityByCity(string city)
    {
        var(lat,lon) = await GetCityCoordinatesAsync(city);
        var response = await _httpClient.GetAsync($"http://api.openweathermap.org/data/2.5/air_pollution?lat={lat}&lon={lon}&appid={_apiKey}");
        response.EnsureSuccessStatusCode();
        var data = await response.Content.ReadAsStringAsync();
        return data;
    }

    public async Task<string> GetCurrentWeatherByPincode(string pincode)
    {
        var response = await _httpClient.GetAsync($"http://api.openweathermap.org/data/2.5/weather?zip={pincode},in&appid={_apiKey}&units=metric");
        response.EnsureSuccessStatusCode();
        var data = await response.Content.ReadAsStringAsync();
        return data;
    }


    public async Task<(double lat, double lon)> GetCityCoordinatesAsync(string city)
{
    var response = await _httpClient.GetAsync($"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}");
    response.EnsureSuccessStatusCode();
 
    var data = await response.Content.ReadAsStringAsync();
    var weatherData = JObject.Parse(data);
 
    double lat = (double)weatherData["coord"]["lat"];
    double lon = (double)weatherData["coord"]["lon"];
 
    return (lat, lon);
}
}
