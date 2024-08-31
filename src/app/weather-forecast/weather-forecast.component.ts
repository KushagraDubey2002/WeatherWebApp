
import { Component } from '@angular/core';
import { WeatherService } from '../weather.service';

@Component({
  selector: 'app-weather-forecast',
  templateUrl: './weather-forecast.component.html',
})
export class WeatherForecastComponent {
  city = '';
  forecastData: any;

  constructor(private weatherService: WeatherService) {}

  getForecast() {
    this.weatherService.get5DayForecast(this.city).subscribe(
      (data) => {
        this.forecastData = data;
      },
      (error) => {
        console.error('Error fetching forecast data', error);
      }
    );
  }
}
