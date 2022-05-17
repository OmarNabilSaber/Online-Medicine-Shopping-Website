using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Online_Medicine_Shopping_Website.Models
{
    public class Bill
    {
        [Key]
        public int BillId { set; get; }
        [Required]
        public int totalCost { set; get; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }

        /*public Product ProdutObject = new Product();*/

        public virtual Order Order { get; set; }

    }
}