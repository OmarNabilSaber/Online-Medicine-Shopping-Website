using Online_Medicine_Shopping_Website.Models;
using Online_Medicine_Shopping_Website.viewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Medicine_Shopping_Website.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewCart()
        {
            List<Product> CartProducts = new List<Product>();

            Products products = new Products
            {
                products = CartProducts
            };
            return View(products);
        }
        public ActionResult AddToCart(string Id)
        {
            if (Online_Medicine_Shopping_Website.Models.UserInfo.Logedin)
            {
                return RedirectToAction("ViewCart", "Cart");
            }
            else
            {
                return RedirectToAction("SignIn", "Home");
            }
            
        }
        public ActionResult RemoveFromCart()
        {
            return RedirectToAction("ViewCart", "Cart");
        }
        public ActionResult UpdateQuantity( int NewQuantity)
        {
            if(NewQuantity < 1)
            {
                return RedirectToAction("RemoveFromCart", "Cart");
            }
            else
            {
                return RedirectToAction("ViewCart", "Cart");
            }
            
        }

    }
}