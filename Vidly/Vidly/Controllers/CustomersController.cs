using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _Context;

        public CustomersController()
        {
            _Context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _Context.Dispose();
        }

        public ViewResult New()
        {
            var membershipTypes = _Context.MembershipTypes.ToList();
            var VM = new CustomerFormViewModel
            {
                MembershipTypes = membershipTypes
            };

            return View("CustomerForm", VM);
        }

        [HttpPost]
        public RedirectToRouteResult Save(Customer customer)
        {
            if (customer.Id == 0)
                _Context.Customers.Add(customer);
            else
            {
                var customerInDB = _Context.Customers.Single(c => c.Id == customer.Id);

                customerInDB.Name = customer.Name;
                customerInDB.BirthDate = customer.BirthDate;
                customerInDB.MembershipTypeId = customer.MembershipTypeId;
                customerInDB.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            }


            _Context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Edit( int id)
        {
            var customer = _Context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            var VM = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _Context.MembershipTypes
            };

            return View("CustomerForm", VM);
        }

        public ViewResult Index()
        {
            var customers = _Context.Customers.Include( c => c.MembershipType).ToList();        //eager loading, ladowanie obiektu membershiptype w obiekcie customer

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _Context.Customers.Include( c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

    }
}