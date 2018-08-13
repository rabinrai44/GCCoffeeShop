using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GCCoffeeShop.Models
{
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
    }
}