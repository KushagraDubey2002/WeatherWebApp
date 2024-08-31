using WeatherWebApp_Model;

namespace WeatherWebApp_Interface
{
    public interface IOpenWeatherRepository{
        Task<string> GetCurrentWeatherByCity(string city);
        Task<string> Get5DayForecastByCity(string city);
        Task<string> GetAirQualityByCity(string city);
        Task<string> GetCurrentWeatherByPincode(string pincode);

    }
}