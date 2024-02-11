using Microsoft.AspNetCore.Mvc;

namespace Lab2RoutingNavigationConfigure.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BaseController : Controller
    {
        public IActionResult BaseIndex()
        {
            return View();
        }
    }
}
