using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _Context;

        public MoviesController()
        {
            _Context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _Context.Dispose();
        }


        public ViewResult Index()
        {
            return View(_Context.Movies.ToList());
        }

        public ActionResult Details(int id)
        {
            var movie = _Context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }
    }
}