
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
namespace Survey.Controllers
{
    public class SurveyController: Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }



        [HttpGet]
        [HttpPost]
        [Route("SurveyResults")]
        public IActionResult result(string name, string location, string programlang, string comment)
        {
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.programlang = programlang;
            ViewBag.comment = comment;  
            return View("SurveyResults");
        }
    }


}