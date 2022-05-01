using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WeatherApp.Control;

namespace WeatherApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            ForecastControl control = new ForecastControl();
            control.GetForecastInfo();
            control.LaunchServer();
            control.ResponseThread();
        }
    }
}
