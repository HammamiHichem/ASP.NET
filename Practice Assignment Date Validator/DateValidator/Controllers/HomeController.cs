using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Submit(MyModel model)
    {
        if (ModelState.IsValid)
        {
            // Le modèle est valide, effectuez des actions appropriées ici
            return RedirectToAction("Success");
        }
        // Le modèle est invalide, retournez la vue avec le modèle pour afficher les erreurs de validation
        return View("Index", model);
    }

    public IActionResult Success()
    {
        return View();
    }
}
