import { Component } from '@angular/core';
import { WeatherService } from '../weather.service';

@Component({
  selector: 'app-weather-by-pincode',
  templateUrl: './weather-by-pincode.component.html',
})
export class WeatherByPincodeComponent {
  pincode = '';
  weatherData: any;

  constructor(private weatherService: WeatherService) {}

  getWeatherByPincode() {
    this.weatherService.getCurrentWeatherByPincode(this.pincode).subscribe(
      (data) => {
        this.weatherData = data;
      },
      (error) => {
        console.error('Error fetching weather data by pincode', error);
      }
    );
  }
}
