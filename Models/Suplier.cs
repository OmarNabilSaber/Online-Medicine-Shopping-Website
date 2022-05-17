using Online_Medicine_Shopping_Website.viewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Medicine_Shopping_Website.Models
{
    public class Suplier: PersonInformation
    {
        public ICollection<Product> Products = new List<Product>();
        //public Product Product = new Product();    
    }
}