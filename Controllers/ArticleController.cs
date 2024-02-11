using Microsoft.AspNetCore.Mvc;

namespace Lab2RoutingNavigationConfigure.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
