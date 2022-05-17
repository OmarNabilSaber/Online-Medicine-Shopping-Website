using Online_Medicine_Shopping_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Medicine_Shopping_Website.viewModels
{
    public class ProductAndSupliers
    {
        public Product product { get; set; }
        public List<Suplier> supliers { get; set; }

        public List<Suplier> Allsupliers { get; set; }
    }
}