using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return Content("This is my Index!");
        }

        [HttpGet]
        [Route("projects")]
        public IActionResult Projects()
        {
            return Content("These are my projects!");
        }

        [HttpGet]
        [Route("contact")]
        public IActionResult Contact()
        {
            return Content("This is my Contact!");
        }
    }
}
