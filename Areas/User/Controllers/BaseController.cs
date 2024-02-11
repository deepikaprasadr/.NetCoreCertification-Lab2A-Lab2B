using Microsoft.AspNetCore.Mvc;

namespace Lab2RoutingNavigationConfigure.Areas.User.Controllers
{
    [Area("User")]
    public class BaseController : Controller
    {
        public IActionResult BaseIndex()
        {
            return View();
        }
    }
}
