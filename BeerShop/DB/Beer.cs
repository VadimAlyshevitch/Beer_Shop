using System;
using System.Collections.Generic;
using System.Text;

namespace DB
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
