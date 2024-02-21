using Lab2RoutingNavigationConfigure.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;


namespace Lab2RoutingNavigationConfigure.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            LoginViewModel usermodel = new LoginViewModel();
            string loginwelcomemsg= (string)TempData["userGreetings"];
           ViewData["welcomemsg"] = loginwelcomemsg;
           string usernamecookieval= Request.Cookies["cookie1"];

            string strUser2 = "";
            strUser2 = HttpContext.Session.GetString("User");
            LoginViewModel user2 = JsonSerializer.Deserialize<LoginViewModel>(strUser2); //convert string to object


            string strUserTempData = TempData.Peek("User") as string;
            usermodel = JsonSerializer.Deserialize<LoginViewModel>(strUserTempData);
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
