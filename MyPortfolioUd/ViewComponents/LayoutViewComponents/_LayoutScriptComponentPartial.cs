using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUd.ViewComponents.LayoutViewComponents
{
    public class _LayoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
