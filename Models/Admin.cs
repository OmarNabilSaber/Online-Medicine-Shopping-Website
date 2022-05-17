using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Medicine_Shopping_Website.Models
{
    public class Admin : PersonInformation
	{
		private static Admin theAdmin { get; set; }

		private Admin() { } // end of constructor 


		public Admin getInstance()
		{

			if (theAdmin == null)
			{
				theAdmin = new Admin();
			}
			return theAdmin;
		}
		//public Suplier SuplierObject = new Suplier();

		//public Product ProductObject = new Product();
		//public LogIn LogInObject = new LogIn();
		//public Regestration RegestrationObject = new Regestration();


    }
}