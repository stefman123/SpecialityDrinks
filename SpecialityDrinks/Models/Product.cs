using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpecialityDrinks.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public double Size { get; set; }

        public double Strength { get; set; }

        public decimal Price { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }
}