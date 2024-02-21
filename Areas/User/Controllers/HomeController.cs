using Microsoft.AspNetCore.Mvc;

namespace Lab2RoutingNavigationConfigure.Areas.User.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            string loginsuccess=(string)TempData.Peek("loginsuccess");
            ViewBag.loginmsg = loginsuccess;


            //TempData["loginsuccess"] = welcomemsg;

            return View();
        }

        public IActionResult UserProfile()
        {
            return View();
        }
    }
}
