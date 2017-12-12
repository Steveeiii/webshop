using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webShop
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double SpecialOffer { get; set; }
        public double NormalPrice { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}