using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUd.ViewComponents.LayoutViewComponents
{
    public class _LayoutHeadComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
