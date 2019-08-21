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



        public ActionResult New()
        {
            var viewModel = new NewCustomerViewModel
            {

                //TypeOfMembership = GetMembershipType().ToList();

            };

           return View(viewModel);
        }

        //private List<NewCustomerViewModel> GetMembershipType()
        //{
        //    return new List<NewCustomerViewModel>
        //    {
        //        new NewCustomerViewModel { TypeOfMembership = "Daily"},
        //        new NewCustomerViewModel { TypeOfMembership = "Monthly"},
        //        new NewCustomerViewModel { TypeOfMembership = "Quarterly"},
        //        new NewCustomerViewModel {TypeOfMembership = "Yearly"}
        //    };
        //}

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _contexxt.Customers.Add(customer);
            _contexxt.SaveChanges();
            return RedirectToAction("Index", "Customer");
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

        public ActionResult Edit(int id)
        {
            var customer = _contexxt.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View("CustomerForm");

        }

      
    }
}