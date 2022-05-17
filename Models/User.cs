using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Online_Medicine_Shopping_Website.Models
{
    public class User:PersonInformation
    {


        [Required]
        [StringLength(20)]
        [Display(Name = "Visa Numper")]
        public string VisaNumper { get; set; }
        [Required]
        [StringLength(4)]
        [Display(Name = "Cvv")]
        public string Cvv { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        /*public Order order = new Order();*/

        //public LogIn LogInObject = new LogIn();

        //public Regestration RegestrationObject = new Regestration();

        //public Search SearchObject = new Search();


    }


}