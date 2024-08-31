# Weather Web App
Overview:

The Weather Web App is a responsive application that provides real-time weather information, including current conditions, a 5-day forecast, and air quality data for a user-specified location. This project is built using ASP.NET Core Web API for the backend and Angular 16 for the frontend.

Features
Current Weather: Get the latest weather data for any city or pincode.
5-Day Forecast: View a detailed weather forecast for the next 5 days.
Air Quality: Check the air quality index (AQI) for the specified location.
Responsive Design: Optimized for both desktop and mobile devices.
Error Handling: Informative error messages and validations for a smooth user experience.
Technologies Used
Backend: ASP.NET Core Web API
Frontend: Angular 16
API Consumption: OpenWeather API
IDE: Visual Studio Code

Getting Started
Prerequisites
.NET SDK: Ensure that the .NET SDK is installed on your machine.
Node.js & npm: Required for running the Angular frontend.
API Key: Obtain an API key from OpenWeather and configure it in your project.

Project Structure
/WeatherApi: Contains the ASP.NET Core Web API backend.
/WeatherApp: Contains the Angular frontend.
/Docs: Documentation files.
Usage
Search by City: Enter a city name in the search bar to retrieve weather information.
Search by Pincode: Use a pincode to get current weather data for that area.
View Forecast and Air Quality: Navigate to the relevant sections to view detailed forecasts and air quality data.

API Endpoints
Current Weather by City: GET /weather/current?city={city}
5-Day Forecast by City: GET /weather/forecast?city={city}
Air Quality by City: GET /weather/airquality?city={city}
Current Weather by Pincode: GET /weather/current?pincode={pincode}

Contributing
Contributions are welcome! Please fork this repository, create a new branch, and submit a pull request.
