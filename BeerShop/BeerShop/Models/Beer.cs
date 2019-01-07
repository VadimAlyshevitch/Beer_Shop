using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerShop.Models
{
    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Alcohol { get; set; }
        public DateTime DateCreate { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
    }
}
