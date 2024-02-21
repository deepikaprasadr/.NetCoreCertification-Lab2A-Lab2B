using Lab2RoutingNavigationConfigure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Lab2RoutingNavigationConfigure.Controllers
{
    public class AccountController : Controller
    {
        //public ViewResult Login()
        //{
        //    return View();
        //}
        string welcomemsg = "";
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
            LoginViewModel usermodel=new LoginViewModel();
            usermodel.Username = username;
            usermodel.Password = password;

            string onlyusername = "";
            int atposition = 0;
            //www.c-sharpcorner.com/UploadFile/mahesh/substring-in-C-Sharp/#:~:text=You%20can%20use%20the%20Substring,position%20of%20the%20specified%20characters.
            atposition = username.IndexOf("@");
            onlyusername=username.Substring(0,atposition);
            //code-maze.com/csharp-first-letter-upper-case/#:~:text=Make%20Use%20of%20Char.&text=The%20FirstCharToUpper()%20method%20takes,convert%20it%20to%20upper%20case.
            onlyusername = char.ToUpper(onlyusername[0]) + onlyusername.Substring(1);

            //lab2c-add a user to a session and clear session on logout 
            HttpContext.Session.SetString("UserSession", JsonSerializer.Serialize(usermodel));

            // if (ModelState.IsValid)   // RedirectToAction("Index", "Home");
            if (username=="user@gmail.com" && password=="12345")
            {
                welcomemsg = "Welcome" +" " + onlyusername;
                //after login
                TempData["loginsuccess"] = welcomemsg;

                //add cookies
                Response.Cookies.Append("cookie1", username, new CookieOptions { Expires = DateTime.Now.AddDays(7) });
                Response.Cookies.Append("cookie2", password, new CookieOptions { Expires=DateTime.Now.AddDays(7) });


                return RedirectToAction("Index", "Home", new { area = "User" });//Areas
            }

            else if(username=="admin@gmail.com" && password== "12345")
            {
                welcomemsg="Welcome" + " "+onlyusername;
                TempData["userGreetings"]= welcomemsg;

                //2c pass model to another controller
                TempData["User"] = JsonSerializer.Serialize(usermodel); // read the value in admin areas HomeController
                 
                //add cookies
                Response.Cookies.Append("cookie1", username, new CookieOptions { Expires = DateTime.Now.AddDays(7) });
                Response.Cookies.Append("cookie2", password, new CookieOptions { Expires = DateTime.Now.AddDays(7) });


                return RedirectToAction("Index", "Home", new { area = "Admin" });//Areas
            }
            else
            {
                ViewData["InvalidUserMsg"] = "Credential unmatch/Credential doesn't exist";
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
            HttpContext.Session.Remove("UserSession");

            //RedirectToAction("Login", "Account");

            string? UserName = Request.Cookies["cookie1"];
            string? password = Request.Cookies["cookie2"];
             
            

            Response.Cookies.Delete("cookie1");
            Response.Cookies.Delete("cookie2");

            return View("Login");
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
