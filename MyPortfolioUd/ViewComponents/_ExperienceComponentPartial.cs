using Microsoft.AspNetCore.Mvc;
using MyPortfolioUd.DAL.Context;

namespace MyPortfolioUd.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
