namespace WeatherWebApp_Model{
    public class ForecastModel
    {
        public string City { get; set; }
        public List<WeatherModel> DailyForecasts { get; set; }
    }
}