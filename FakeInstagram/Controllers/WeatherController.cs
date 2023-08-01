using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using FakeInstagram.Models;
using Microsoft.AspNetCore.WebUtilities;

namespace FakeInstagram.Controllers
{
    [Route("[controller]")]
    public class WeatherController : Controller
    {
        private readonly ILogger<WeatherController> _logger;
        private readonly static HttpClient weatherClient = new();
        private readonly string weatherAPIKey = string.Empty;

        public WeatherController(ILogger<WeatherController> logger, IOptions<WeatherAPIOptions> weatherOptions)
        {
            _logger = logger;
            weatherAPIKey = weatherOptions.Value.Key;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ViewBag.weatherInfo = await GetWeatherInfoAsync();
            // Console.WriteLine(weatherInfo);
            return View();
        }

        private async Task<string> GetWeatherInfoAsync(string countryName = "")
        {
            var values = new Dictionary<string, string>
            {
                {"Key", $"{weatherAPIKey}"},
                {"q", $"{"London"}"},
            };
            var requestUri = QueryHelpers.AddQueryString("https://api.weatherapi.com/v1/current.json", values);
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            var response = await weatherClient.SendAsync(request);
            if (response.StatusCode is not System.Net.HttpStatusCode.OK)
            {
                return $"Something went wrong.\nStatusCode: {response.StatusCode.ToString()}\n{await response.Content.ReadAsStringAsync()}";
            }
            return await response.Content.ReadAsStringAsync();
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}