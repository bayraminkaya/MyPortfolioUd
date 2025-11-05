using Microsoft.AspNetCore.Mvc;
using MyPortfolioUd.DAL.Context;

namespace MyPortfolioUd.ViewComponents
{
    public class _AboutComponentpartial : ViewComponent 
    {
        MyPortfolioContext portfolioContext= new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = portfolioContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription = portfolioContext.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail = portfolioContext.Abouts.Select(x => x.Details).FirstOrDefault();
            
            return View();
        }
    }
}
