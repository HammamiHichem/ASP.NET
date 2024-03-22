using Microsoft.AspNetCore.Mvc;
using Form_Submission.Models; // Assurez-vous d'importer le bon espace de noms

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Submit(FormData formData)
    {
        if (ModelState.IsValid)
        {
            // Traitement des données en cas de succès
            return RedirectToAction("Success");
        }
        // Renvoyer la vue avec le modèle pour afficher les erreurs de validation
        return View("Index", formData);
    }

    public IActionResult Success()
    {
        return View();
    }
}
