using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string message = "Here is a message";
            return View("Index", message);
        }

        public IActionResult Numbers()
        {
            string message = "Here are some numbers";
            int[] numbers = { 1, 2, 10, 21, 8, 7, 3 };
            ViewBag.Message = message;
            return View("Numbers", numbers);
        }

        public IActionResult UserPage() // Renommé User() en UserPage()
        {
            string message = "Here is a user";
            var user = new User { FirstName = "Neil", LastName = "Gaiman" };
            ViewBag.Message = message;
            return View("User", user);
        }

        public IActionResult Users()
        {
            string message = "Here is a list of users";
            var users = new List<User>
            {
                new User { FirstName = "Neil", LastName = "Gaiman" },
                new User { FirstName = "Terry", LastName = "Pratchett" },
                new User { FirstName = "Jane", LastName = "Austen" },
                new User { FirstName = "Stephen", LastName = "King" }
            };
            ViewBag.Message = message;
            return View("Users", users);
        }
    }
}
