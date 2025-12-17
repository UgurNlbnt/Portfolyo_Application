using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutSlideBarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
