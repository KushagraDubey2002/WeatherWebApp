using Microsoft.AspNetCore.Mvc;
using WeatherWebApp_Interface;

[ApiController]
[Route("api/[controller]")]
public class WeatherController : ControllerBase
{
    private readonly IOpenWeatherRepository weatherService;

    public WeatherController(IOpenWeatherRepository _weatherService)
    {
        weatherService = _weatherService;
    }

    [HttpGet("current")]
    public async Task<IActionResult> GetCurrentWeatherByCity(string city)
    {
        try{
            var weather = await weatherService.GetCurrentWeatherByCity(city);
            return Ok(weather);
        }
        catch (HttpRequestException ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "Error fetching data from OpenWeather API");
        }
    }

    [HttpGet("forecast")]
    public async Task<IActionResult> Get5DayForecastByCity(string city)
    {
        try{
            var forecast = await weatherService.Get5DayForecastByCity(city);
            return Ok(forecast);
        }
        catch (HttpRequestException ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "Error fetching data from OpenWeather API");
        }
    }

    [HttpGet("airquality")]
    public async Task<IActionResult> GetAirQualityByCity( string city)
    {
        try{
            var airQuality = await weatherService.GetAirQualityByCity(city);
            return Ok(airQuality);
        }
        catch (HttpRequestException ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "Error fetching data from OpenWeather API");
        }
    }

    [HttpGet("currentbypincode")]
    public async Task<IActionResult> GetCurrentWeatherByPincode(string pincode)
    {
        try{
            var weather = await weatherService.GetCurrentWeatherByPincode(pincode);
            return Ok(weather);
        }
        catch (HttpRequestException ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "Error fetching data from OpenWeather API");
        }
    }
}
