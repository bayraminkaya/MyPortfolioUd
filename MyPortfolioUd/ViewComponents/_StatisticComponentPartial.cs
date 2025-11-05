using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUd.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
