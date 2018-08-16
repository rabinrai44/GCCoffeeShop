using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GCCoffeeShop
{
    public class ProductList
    {
        private int ProductId { get; set; }
        private string ProductName { get; set; }
        private double ProductPrice { get; set; }

        public ProductList (int id, string name, double price)
        {
            ProductId = id;
            ProductName = name;
            ProductPrice = price;
        }

        public string GetCoffeName()
        {
            return ProductName;
        }

        public double GetCoffePrice()
        {
            return ProductPrice;
        }

    }
}