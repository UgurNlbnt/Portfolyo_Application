
using AkademiQPortfolio.Data;
using Microsoft.AspNetCore.Mvc;


namespace AkademiQPortfolio.Controllers
{
    public class ServicesController : Controller
    {
        private readonly portfolyoDbContext _portfolyodbContext;

        //DI Injection
        public ServicesController(portfolyoDbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IActionResult Index()
        {
            var values = _portfolyodbContext.Services.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateServices()
        {
            return View();

        }

        [HttpPost]
        public IActionResult CreateServices(Service service)
        {
            _portfolyodbContext.Services.Add(service);
            _portfolyodbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateServices(int id)
        {
            var values = _portfolyodbContext.Services.Find(id);
            return View(values);

        }

        [HttpPost]
        public IActionResult UpdateServices(Service service)
        {
            _portfolyodbContext.Services.Update(service);
            _portfolyodbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteServices(int id)
        {
            var values = _portfolyodbContext.Services.Find(id);
            _portfolyodbContext.Services.Remove(values);
            _portfolyodbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
