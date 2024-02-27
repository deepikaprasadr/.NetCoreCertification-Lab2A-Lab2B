using Lab2RoutingNavigationConfigure.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab2RoutingNavigationConfigure.Controllers
{
    public class Lab3RegisterUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterUserModel registerusermodel)
        {
            if(ModelState.IsValid)
            {
                string radiogender = registerusermodel.Gender;
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
