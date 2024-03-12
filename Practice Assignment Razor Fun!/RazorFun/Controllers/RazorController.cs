using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class RazorController : Controller
{
    [HttpGet("")]
    public ViewResult Index()
    {
        List<string> items = new List<string>
        {
            "Apple Pie",
            "Pizza",
            "Cinnamon Rolls",
            "Lasagna",
            "Donuts",
            "Chocolate Cake",
            "Burritos",
            "Cake",
            
        };

        return View(items);
    }
}
