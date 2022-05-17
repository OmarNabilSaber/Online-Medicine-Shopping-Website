using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Online_Medicine_Shopping_Website.Models;
using Online_Medicine_Shopping_Website.viewModels;

namespace Online_Medicine_Shopping_Website.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult SearchResult(String medicineName)
        {
            List<Product> SearchResult = new List<Product>();

            searchResultContent searchResultContent = new searchResultContent
            {
                products = SearchResult , title = medicineName
            };
            return View(searchResultContent); 
        }
        public ActionResult skincareProducts()
        {
            List<Product> recommendOffers = new List<Product>();

            Products products = new Products
            {
                products = recommendOffers
            };
            return View(products);
        }

        public ActionResult recommendOffers()
        {
            List<Product> recommendOffers = new List<Product>();

            Products products = new Products
            {
                products = recommendOffers
            };
            return View(products);
        }

        
    }
}