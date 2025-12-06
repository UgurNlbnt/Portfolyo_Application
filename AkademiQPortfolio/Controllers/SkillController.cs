using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.Controllers;

public class SkillController : Controller
{

    //buraya context kullanacagız 
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult UpdateSkill()
    {
        return View();
    }

    public IActionResult DeleteSkill()
    {
        return View();
    }
}
