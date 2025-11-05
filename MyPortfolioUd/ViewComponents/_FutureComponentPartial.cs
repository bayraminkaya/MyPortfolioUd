using Microsoft.AspNetCore.Mvc;
using MyPortfolioUd.DAL.Context;

namespace MyPortfolioUd.ViewComponents
{
    public class _FutureComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
