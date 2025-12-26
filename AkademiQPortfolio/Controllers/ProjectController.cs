using AkademiQPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AkademiQPortfolio.Controllers
{
    public class ProjectController : Controller
    {
        private readonly portfolyoDbContext _context;
        public ProjectController(portfolyoDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.ProjectsTables.Include(x => x.Category).ToList();
            return View(values);
        }

        //dropdown ---> 2 sütunu var value ve gözüken kısım
        // kullanıcı kategory adını görecek ama value kısmında kategory id olacak

        //selctListItem 
        [HttpGet]
        public IActionResult ProjectCreate()
        {

            //veritabanından kategorileri çekip dropdowna dolduracağız
            ViewBag.Categories = _context.CategoriesTables.Select(x=> new SelectListItem
            {
                Text = x.CategoryName,
                Value = x.CategoryId.ToString()
            });
            return View();
        }

        [HttpPost]
        public IActionResult ProjectCreate(ProjectsTable projectsTable)
        {
            _context.ProjectsTables.Add(projectsTable);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        //guncelelemeyı yaz 

    }
}