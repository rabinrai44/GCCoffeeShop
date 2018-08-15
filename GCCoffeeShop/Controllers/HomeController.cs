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
            // Cookie Testing
            HttpCookie cookie;
            if (Request.Cookies["First Name"] == null)
            {
                cookie = new HttpCookie("First Name")
                {
                    Value = user.FirstName,

                    Expires = DateTime.UtcNow.AddDays(30)
                };
            }
            else
            {
                cookie = Request.Cookies["First Name"];
            }
            // Fetch the info from the cookie

            cookie.Value = user.FirstName;
            Response.Cookies.Add(cookie); // send the cookie back to the client 
            ViewBag.Message = user.FirstName;
            
            return View(user);
        }
    }
}