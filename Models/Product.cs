using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Online_Medicine_Shopping_Website.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Purpose { get; set; }
        [Required]
        public string type { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public float Cost { get; set; }
        [Required]
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string imgUrl { get; set; }
        public float Discount { get; set; }

    }
}