using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.Controllers
{
    public class SkillNewController : Controller
    {
        public IActionResult SkillList()
        {
            return View();
        }
    }
}
