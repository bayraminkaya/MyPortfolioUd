using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUd.ViewComponents
{
    public class _FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
