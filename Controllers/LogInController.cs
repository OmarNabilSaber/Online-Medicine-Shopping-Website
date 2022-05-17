using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Online_Medicine_Shopping_Website.Models;
using System.Data.Entity;

namespace Online_Medicine_Shopping_Website.Controllers
{
    public class LogInController : Controller
    {
        private DataContext db = new DataContext();

        // GET: LogIn
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogIn( LogIn LogInInfo)
        {
            User userInfo = db.Users.SingleOrDefault(s => s.Email == LogInInfo.Email);
            if (userInfo == null)
            {
                ModelState.AddModelError("Email", "This Email is not exists");
                return View();
            }
            else
            {
                if( userInfo.Password != LogInInfo.Password)
                {
                    ModelState.AddModelError("Password", "Incorrect password");
                    return View();
                }

                Online_Medicine_Shopping_Website.Models.UserInfo.Logedin = true; 
                Online_Medicine_Shopping_Website.Models.UserInfo.Id = userInfo.UserId; 
                Online_Medicine_Shopping_Website.Models.UserInfo.UserType = "Admin"; 


                return RedirectToAction("Index", "Home");
            }
        }
    }
}