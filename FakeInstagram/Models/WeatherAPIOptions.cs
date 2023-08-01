using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeInstagram.Models
{
    public class WeatherAPIOptions
    {
        public const string WeatherAPI = "WeatherAPI";
        public string Key {get; set;} = string.Empty;
    }
}