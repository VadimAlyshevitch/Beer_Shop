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

        ApplicationContext db;
        public BeerController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet("init")]
        public IActionResult GetCount()
        {
            Beer beer = new Beer()
            {
                Name = "Балтика",
                Alcohol = 4.7,
                DateCreate = DateTime.Now,
                Price = 69,
                Count = 144
            };
            db.Beers.Add(beer);
            db.SaveChanges();
            return Ok();
        }
    }
}
