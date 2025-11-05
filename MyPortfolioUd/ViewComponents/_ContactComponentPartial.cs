using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUd.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
