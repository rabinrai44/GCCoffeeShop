using System.Data.Entity;
using System.Collections.Generic;
using GCCoffeeShop.Domain.Models;
using System;

namespace GCCoffeeShop.Data
{
    public class GCCoffeeShopInitializer : DropCreateDatabaseIfModelChanges<GCCoffeeShopContext>
    {
        protected override void Seed(GCCoffeeShopContext context)
        {
            //This is where we start to seed our data.
            context.Customers.Add(new Customer()
            {
                Id = 1,
                DOB = new DateTime(10 / 02 / 9190),
                ProductNumber = "1",
                FirstName = "Rabin",
                LastName = "Rai",
                UserName = "rai_rabin",
                Email = "rabinrai44@gmail.com",
                Phone = "232-232-3423",
                Country = "USA",
                StateRegion = "United States",
                City = "Grand Rapids",
                ZipCode = "4912"
            });
            context.SaveChanges();

            context.Products.AddRange(
                new List<Product>
                {
                    new Product()
                    {
                        Id =1,
                        CustomerId = 1
                    },
                }
                );
            context.SaveChanges();

            base.Seed(context);
        }
    }
}