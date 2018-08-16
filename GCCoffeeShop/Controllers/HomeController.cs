using GCCoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GCCoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Feel free to contact us with the following contact list and we'd love to any feedback.";

            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserModel user)
        {
            return RedirectToAction("Welcome", user);

        }

        public ActionResult Welcome(UserModel user)
        {
            // Creating Cookie
            HttpCookie coffeeCookie;
            if (Request.Cookies["Favorite Coffee"] == null)
            {
                coffeeCookie = new HttpCookie("Favorite Coffee")
                {
                    Value = user.FavoriteCoffee,
                    Expires = DateTime.UtcNow.AddDays(60)
                };
            }
            else
            {
                coffeeCookie = Request.Cookies["Favorite Coffee"];
            }
            // Fetch the info from the cookie
            coffeeCookie.Value = user.FavoriteCoffee;
            Response.Cookies.Add(coffeeCookie);
            ViewBag.Message = user.FavoriteCoffee;

            return View(user);
        }

        public ActionResult Product(UserModel user)
        {
            HttpCookie getCoffee = HttpContext.Request.Cookies.Get("Favorite Coffee");

            user.FavoriteCoffee = getCoffee.Value;

            ViewBag.Message = getCoffee.Value;

           return View();
        }
    }
}