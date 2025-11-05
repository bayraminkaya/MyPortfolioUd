using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUd.ViewComponents
{
    public class _HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
