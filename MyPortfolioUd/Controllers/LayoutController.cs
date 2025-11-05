using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUd.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
