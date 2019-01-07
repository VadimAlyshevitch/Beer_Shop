using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeerShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BeerShop.Controllers
{
    [Route("api/beer")]
    public class BeerController : Controller
    {
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

        //[HttpGet("count")]
        //public IActionResult GetCount()
        //{
        //    using (ApplicationContext db = new ApplicationContext())
        //    {
        //        int count = db.Beers.Where(b => b.Id > 0).Count();

        //        return Ok(count);
        //    }
        //}
    }
}
