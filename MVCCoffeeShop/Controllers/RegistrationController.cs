using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoffeeShop.Models;

namespace MVCCoffeeShop.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult RegistrationForm()
        {
            return View();
        }

        public IActionResult DisplayUser(RegisterUser user)
        {
            user.GetUserName();
            return View("DisplayUser", user);
        }
    }
}