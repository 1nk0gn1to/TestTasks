using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public WeatherForecast Get()
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?" +
                "q=Yekaterinburg&units=metric&appid=e241ff1aa1e5b1bf515c6fe7e75b6a9e";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse getresponse = (HttpWebResponse)request.GetResponse();
            string response;
            using (StreamReader sr = new StreamReader(getresponse.GetResponseStream()))
            {
                response = sr.ReadToEnd();
            }
            WeatherForecast weather = JsonConvert.DeserializeObject<WeatherForecast>(response);
            weather.Date = DateTime.Now;
            return weather;
        }
        
    }
}