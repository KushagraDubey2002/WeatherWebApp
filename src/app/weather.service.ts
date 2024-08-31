// import { Injectable } from '@angular/core';

// @Injectable({
//   providedIn: 'root'
// })
// export class WeatherService {

//   constructor() { }
// }

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class WeatherService {
  private baseUrl = 'http://localhost:5134/api/Weather';  // Update with your backend URL

  constructor(private http: HttpClient) {}

  getCurrentWeather(city: string): Observable<any> {
    return this.http.get(`${this.baseUrl}/current?city=${city}`);
  }
  

  get5DayForecast(city: string): Observable<any> {
    return this.http.get(`${this.baseUrl}/forecast?city=${city}`);
  }

  getAirQuality(city: string): Observable<any> {
    return this.http.get(`${this.baseUrl}/airquality?city=${city}`);
  }

  getCurrentWeatherByPincode(pincode: string): Observable<any> {
    return this.http.get(`${this.baseUrl}/currentbypincode?pincode=${pincode}`);
  }
}

