using Microsoft.AspNetCore.Mvc;
namespace Countdown.Controllers;   
public class CountdownController : Controller     
{      
    [HttpGet("")]
    public ViewResult Index()        
    {            
    	return View();        
    }
}