using Online_Medicine_Shopping_Website.Models;
using Online_Medicine_Shopping_Website.viewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Medicine_Shopping_Website.Controllers
{
    public class SuplierController : Controller
    {
        // GET: Suplier
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UpdateSuplier(
            string Id,
            string Frist_Name,
            string Last_Name,
            string Phone,
            string Adress,
            string Email
            )
        {
            return RedirectToAction("moreSuplierDetilse", "Suplier", new { id = Id });
        }

        public ActionResult RemoveSuplier(string id)
        {
            return RedirectToAction("Index", "Admin");
        }
       

        public ActionResult AddprodutToSublier(string ProductId , string SublierId)
        {
            return RedirectToAction("moreSuplierDetilse", "Suplier", new { id = SublierId });
        }
        public ActionResult AddNewSuplierForm ()
        {
            return View();
        }
        public ActionResult AddNewSuplier(
            string Frist_Name,
            string Last_Name,
            string Phone,
            string Adress,
            string Email
            )
        {
            int Id = 0;
            return RedirectToAction("moreSuplierDetilse", "Suplier", new { id = Id });
        }

    }
}