using Microsoft.AspNetCore.Mvc;
namespace PortfolioI.Controllers;
public class HomeController : Controller
{
    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {
        return View("Home");
    }

    [HttpGet("projects")]
    public ViewResult Project()
    {
        return View("Project");
    }

    [HttpGet("contact")]
    public ViewResult Contact()
    {
        return View("Contact");
    }
}