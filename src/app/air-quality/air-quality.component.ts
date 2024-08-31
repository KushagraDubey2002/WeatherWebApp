
import { Component } from '@angular/core';
import { WeatherService } from '../weather.service';

@Component({
  selector: 'app-air-quality',
  templateUrl: './air-quality.component.html',
})
export class AirQualityComponent {
  city = '';
  airQualityData: any;

  constructor(private weatherService: WeatherService) {}

  getAirQuality() {
    this.weatherService.getAirQuality(this.city).subscribe(
      (data) => {
        this.airQualityData = data;
      },
      (error) => {
        console.error('Error fetching air quality data', error);
      }
    );
  }
}
