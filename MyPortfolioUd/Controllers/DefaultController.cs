using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUd.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
