using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Online_Medicine_Shopping_Website.Models;

namespace Online_Medicine_Shopping_Website.viewModels
{
    public class SupliersAndUsersAndProductsAndOrders
    {
        public List<User> Users { get; set; }
        public List<Suplier> Supliers { get; set; }
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }
    }
}