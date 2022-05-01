using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace WeatherApp.Control
{
    internal class ForecastControl
    {
        public void GetForecastInfo()
        {
            DateTime currentDatetime = DateTime.Now;
            string url = "https://api.openweathermap.org/data/2.5/weather?" +
                "q=Yekaterinburg&units=metric&appid=e241ff1aa1e5b1bf515c6fe7e75b6a9e";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse getresponse = (HttpWebResponse)request.GetResponse();
            string response;
            using (StreamReader sr = new StreamReader(getresponse.GetResponseStream()))
            {
                response = sr.ReadToEnd();
            }
            WeatherInCity weather = JsonConvert.DeserializeObject<WeatherInCity>(response);
            Console.WriteLine($"Weather in {weather.Name} : {(int)weather.Main.Temp}\nCurrent datetime :{currentDatetime:O}");
        }
    }
}
