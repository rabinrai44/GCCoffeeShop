using GCCoffeeShop.Domain.Models;
using System.Data.Entity;

namespace GCCoffeeShop.Data
{
    public class GCCoffeeShopContext : DbContext
    {
        public GCCoffeeShopContext()
        {
            //Drop the database and recreate on each run
            //Database.SetInitializer(new DropCreateDatabaseAlways<GrandCircusLmsContext>());
            // Create the DB if it doesn't exist.  
            //Database.SetInitializer(new CreateDatabaseIfNotExists<GrandCircusLmsContext>());
            //Will Drop and recreate if model changes.
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<GrandCircusLmsContext>());
            //Custom Initializer
            Database.SetInitializer(new GCCoffeeShopInitializer());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; } 
    }
}
