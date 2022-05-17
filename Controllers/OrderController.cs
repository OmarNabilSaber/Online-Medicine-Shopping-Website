using Online_Medicine_Shopping_Website.Models;
using Online_Medicine_Shopping_Website.viewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Medicine_Shopping_Website.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViweOrders( string Id )
        {
            List<Order> Orders = new List<Order> 
            {
            };

            Orders orders = new Orders { 
                orders = Orders 
            };
            return View(orders);
        }
        public ActionResult AddOrder()
        {
            return RedirectToAction("ViweOrders", "Order");
        }
        public ActionResult ViewOrder(string Id)
        {
            Order order = new Order
            {
            };
            return View(order);
        }
        public ActionResult ChangeState(string id , string newStat)
        {
            return RedirectToAction("ViewOrder", "Order", new { Id = id });
        }
    }

    
}