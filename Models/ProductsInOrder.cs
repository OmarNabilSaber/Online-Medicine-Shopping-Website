using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Online_Medicine_Shopping_Website.Models
{
    public class ProductsInOrder
    {
        [ForeignKey("Order")]
        public int OrderId { set; get; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}