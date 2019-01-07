using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BeerShop.Controllers
{
    [Route("api/beer")]
    public class BeerController : Controller
    {
        //private static string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        //[HttpGet("[action]")]
        //public IEnumerable<WeatherForecast> WeatherForecasts()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    });
        //}
        private static string[] Beers = new[]
        {
            "Оболонь", "Балтика", "Арсенальное", "Жигуль", "Козел", "Охота", "Туборг", "Бад", "Гараж", "Куллер"
        };

        [HttpGet("isExists")]
        public IActionResult IsExists(string beerTitle)
        {
            
            bool isExists = Beers.Contains(beerTitle);
            return Json(new
            {
                result = isExists
            });
        }
    }
}
