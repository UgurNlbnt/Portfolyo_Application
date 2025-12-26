using AkademiQPortfolio.Data;
using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.ViewComponents;

public class ExperinceViewComponent : ViewComponent
{
    private readonly portfolyoDbContext _context;
    public ExperinceViewComponent(portfolyoDbContext context)
    {
        _context = context;
    }
    public IViewComponentResult Invoke()
    {
        var value = _context.Services.ToList();
        return View();
    }
}
