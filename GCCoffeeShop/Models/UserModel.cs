using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GCCoffeeShop.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "First Name Required")]
        [Display(Name = "First Name")]
        [StringLength(30, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(30, MinimumLength = 3)]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Email Required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username is Required")]
        [Display(Name = "Username")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Username must be between 5 to 50 characters long")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password Required")]
        [StringLength(255, MinimumLength = 5, ErrorMessage = "Password must be between 5 to 255 characters long")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password Required")]
        [Display(Name = "Confirm")]
        [StringLength(255, MinimumLength = 5, ErrorMessage = "Confirm password must be between 5 to 255 characters long")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone Number")]
        public string Phone { get; set; }

        
        public string Country { get; set; }

        [Display(Name = "State/Region")]
        public string StateRegion { get; set; }


    }
}