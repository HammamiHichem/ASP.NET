using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;

namespace SessionWorkshop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username)
        {
            if (!string.IsNullOrEmpty(username))
            {
                HttpContext.Session.SetString("username", username);
                HttpContext.Session.SetInt32("value", 22);
                return RedirectToAction("Dashboard");
            }
            return View();
        }

        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("username") == null)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Username = HttpContext.Session.GetString("username");
            ViewBag.Value = HttpContext.Session.GetInt32("value");

            return View();
        }

        [HttpPost]
        public IActionResult PerformOperation(string operation)
        {
            int? value = HttpContext.Session.GetInt32("value");

            if (value != null)
            {
                switch (operation)
                {
                    case "add":
                        HttpContext.Session.SetInt32("value", (int)value + 1);
                        break;
                    case "subtract":
                        HttpContext.Session.SetInt32("value", (int)value - 1);
                        break;
                    case "multiply":
                        HttpContext.Session.SetInt32("value", (int)value * 2);
                        break;
                    case "random":
                        Random rnd = new Random();
                        HttpContext.Session.SetInt32("value", (int)value + rnd.Next(1, 11));
                        break;
                    case "logout":
                        HttpContext.Session.Clear();
                        return RedirectToAction("Index", "Home"); // Redirige vers la page d'accueil
                }
            }

            return RedirectToAction("Dashboard");
        }

        [HttpPost]
        public IActionResult ResetValue()
        {
            HttpContext.Session.SetInt32("value", 0);
            return RedirectToAction("Dashboard");
        }
    }
}
