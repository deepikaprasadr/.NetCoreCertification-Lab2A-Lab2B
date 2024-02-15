using Lab2RoutingNavigationConfigure.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab2RoutingNavigationConfigure.Controllers
{
    public class AccountController : Controller
    {
        //public ViewResult Login()
        //{
        //    return View();
        //}

        public IActionResult Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            else
                return View();
        }


        // public IActionResult Login(string username, string password)
        //public IActionResult Login(IFormCollection form)   -try to use - if not sure how many textboxees are there
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // if (ModelState.IsValid)   // RedirectToAction("Index", "Home");
            if(username=="user@gmail.com" && password=="12345")
            {

                return RedirectToAction("Index", "Home", new { area = "User" });//Areas
            }

            else if(username=="admin@gmail.com" && password== "12345")
            {
                return RedirectToAction("Index", "Home", new { area = "Admin" });//Areas
            }
            return View();
           
        }
           public IActionResult Signup()
        {
            return View();
        }

            public void razorsyntaxpage()
        {
            if (ModelState.IsValid) { }
        }

        public IActionResult Logout()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Login(IFormCollection formcollection)
        //{
        //    string username = formcollection["Username"];
        //    string password = formcollection["Password"];
        //    return View();
        //}
    }
}
