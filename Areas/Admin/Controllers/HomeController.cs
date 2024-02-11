using Microsoft.AspNetCore.Mvc;

namespace Lab2RoutingNavigationConfigure.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Logout()
        {
            return View();
        }
    }
}
