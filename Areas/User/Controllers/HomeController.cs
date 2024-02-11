using Microsoft.AspNetCore.Mvc;

namespace Lab2RoutingNavigationConfigure.Areas.User.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserProfile()
        {
            return View();
        }
    }
}
