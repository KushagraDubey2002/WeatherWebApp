using Microsoft.OpenApi.Models;
using WeatherWebApp_Interface;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Weather API", Version = "v1" });
});


builder.Services.AddHttpClient<IOpenWeatherRepository, OpenWeatherService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["OpenWeatherApi:BaseUrl"]);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.UseAuthorization();
app.UseCors(options =>
{
    options.AllowAnyHeader();  
    options.AllowAnyOrigin();
    options.AllowAnyMethod();
});
app.MapControllers();
app.Run();