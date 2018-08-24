using System.Collections.Generic;

namespace GCCoffeeShop.Domain.Models
{
    public class Customer : Person
    {
        public string ProductNumber { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
