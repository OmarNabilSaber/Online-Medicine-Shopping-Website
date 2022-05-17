using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Online_Medicine_Shopping_Website.Models;
using Online_Medicine_Shopping_Website.viewModels;

namespace Online_Medicine_Shopping_Website.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        

    }
}