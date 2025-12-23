using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.Controllers;

public class ExperinceController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult CreateExperience()
    {
        return View();
    }

    public IActionResult UpdateExperience()
    {
        return View();
    }

    public IActionResult DeleteExperience() 
    {
        return RedirectToAction("Index");
    }

}
