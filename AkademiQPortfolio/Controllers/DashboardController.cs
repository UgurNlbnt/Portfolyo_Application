using AkademiQPortfolio.Data;
using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.Controllers
{
    public class DashboardController : Controller
    {
        private readonly portfolyoDbContext _context;

        public DashboardController(portfolyoDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.firstProjest = _context.ProjectsTables.FirstOrDefault().ProjectName;
            ViewBag.lastProjest = _context.ProjectsTables.OrderByDescending(p => p.ProjectId).FirstOrDefault().ProjectName;
            ViewBag.totalProjects = _context.Services.Count();
            ViewBag.FirstCategory = _context.CategoriesTables.FirstOrDefault().CategoryName;

            //en çok projeye sahip kategori

            //yetenekler de en büyük orana sahip yetenek
            return View();
        }
    }
}
