using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoffeeShop.Models
{
    public class RegisterUser
    {
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 30 characters.")]
        public string UserName { get; set; }

        [Required]
        //[RegularExpression(@"", ErrorMessage = "Email must... be an email.")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*\d).{4}$", ErrorMessage = "Password must be at least 4 characters, and include a number")]
        public string Password { get; set; }

        public void GetUserName()
        {
            UserName = UserName;
        }

    }
}
