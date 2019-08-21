using Roller.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Roller.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _contexxt;


        //Why?
        public CustomerController()
        {
            _contexxt = new ApplicationDbContext();
        }

        //Why?
        protected override void Dispose(bool disposing)
        {
            _contexxt.Dispose();    
        }

        // GET: Customer
        public ActionResult Index()
        {
            var customers = _contexxt.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }


        public ActionResult Details(int id)
        {
            var customer = _contexxt.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

      
    }
}