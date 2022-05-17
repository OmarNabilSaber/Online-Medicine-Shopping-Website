using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Online_Medicine_Shopping_Website.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }   
        public State State { get; set; }
        public DateTime Date { get; set; }
        public float TotalCost { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ProductsInOrder> ProductsInOrder { get; set; }

        //public Bill BillObject = new Bill();
        //public Product ProductOdjectv = new Product();
        

    }
    public enum State
    {
        In_progress , Done
    }
}