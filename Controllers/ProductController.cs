using Online_Medicine_Shopping_Website.Models;
using Online_Medicine_Shopping_Website.viewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Medicine_Shopping_Website.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProductDetails(String Id)
        {
           
          

            ProductAndSupliers productAndSupliers = new ProductAndSupliers
            {
                
            };
            return View(productAndSupliers);
        }

        public ActionResult UpdateProduct(
            string Id,
            string Name,
            float Cost,
            float Discount,
            float Price,
            int Quantity,
            string type,
            string imgUrl,
            string Description
            )
        {
            return RedirectToAction("ProductDetails", "Product", new { id = Id });
        }
        public ActionResult RemoveProduct(string id)
        {
            return RedirectToAction("Index", "Admin");
        }
        public ActionResult AddSuplierToProduct(string SuplierId)
        {
            return RedirectToAction("ProductDetails", "Product");
        }
        public ActionResult AddNewProductForm()
        {
            return View();
        }
        public ActionResult AddNewProduct(
            string Name,
            float Cost,
            float Discount,
            float Price,
            int Quantity,
            string type,
            string imgUrl,
            string Description
            )

        {
            string Id = "323323";
            return RedirectToAction("ProductDetails", "Product", new { id = Id });
        }
    }
}