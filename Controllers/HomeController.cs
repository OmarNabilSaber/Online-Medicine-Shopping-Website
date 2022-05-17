using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Online_Medicine_Shopping_Website.Models;
using Online_Medicine_Shopping_Website.viewModels;

namespace Online_Medicine_Shopping_Website.Controllers 
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    

        public ActionResult SignOut() 
        {
            Online_Medicine_Shopping_Website.Models.UserInfo.UserType = "User";
            Online_Medicine_Shopping_Website.Models.UserInfo.Logedin = false;
            return RedirectToAction("Index", "Home");
        }  
        


    }
}