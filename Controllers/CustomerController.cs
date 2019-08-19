using Roller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Roller.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customer = new List<Customer>()
            {
                 new Customer {Name = "John Smith"},
                new Customer {Name = "Dele Ali"},
                new Customer {Name = "Abu Dhaby"}

            };
            return View(customer);
        }
    }
}