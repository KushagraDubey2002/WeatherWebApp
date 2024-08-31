import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CurrentWeatherComponent } from './current-weather/current-weather.component';
import { WeatherForecastComponent } from './weather-forecast/weather-forecast.component';
import { AirQualityComponent } from './air-quality/air-quality.component';
import { WeatherByPincodeComponent } from './weather-by-pincode/weather-by-pincode.component';

const routes: Routes = [
  { path: 'current-weather', component: CurrentWeatherComponent },
  { path: 'forecast', component: WeatherForecastComponent },
  { path: 'air-quality', component: AirQualityComponent },
  { path: 'weather-by-pincode', component: WeatherByPincodeComponent },
  { path: '', redirectTo: '/current-weather', pathMatch: 'full' } 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
