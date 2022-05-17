using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Online_Medicine_Shopping_Website.Models;
using System.Data.Entity;

namespace Online_Medicine_Shopping_Website.Controllers
{
    public class RegestrationController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Regestration
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(); 
        }
        [HttpPost]
        public ActionResult Create( User user)
        {
            if (ModelState.IsValid)
            {
                User userInfo = db.Users.SingleOrDefault(s => s.Email == user.Email);
                if( userInfo != null)
                {
                    ModelState.AddModelError("Email", "This Email is already exists");
                    return View();
                }
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("LogIn" ,"LogIn");
            }
            return View(); 
        }
    }
}