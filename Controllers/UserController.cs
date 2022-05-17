using Online_Medicine_Shopping_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Medicine_Shopping_Website.Controllers
{
    public class UserController : Controller
    {
        // GET: validation
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit( int? id )
        {
            User userinfo = new User
            {
                FristName = "Omar",
                LastName = "Nabil",
                Adress = "blablabal",
                Email = "omarnabilsaber@gmail.com",
                Phone = "01032037988",
                Password = "r83-284-",
                VisaNumper = "98495849589849",
                Cvv = "4385"
            };
            return View(userinfo);
        }
        [HttpPost]
        public ActionResult Edit( User UserInfo)
        {
            
            return View(UserInfo);
        }


        public ActionResult ViewProfile( int? id)
        {
            User userinfo = new User
            {
                FristName = "Omar",
                LastName = "Nabil",
                Adress = "blablabal",
                Email = "omarnabilsaber@gmail.com",
                Phone = "01032037988",
                Password = "r83-284-",
                VisaNumper = "98495849589849",
                Cvv = "4385"
            };
            return View(userinfo);
        }

    }
}