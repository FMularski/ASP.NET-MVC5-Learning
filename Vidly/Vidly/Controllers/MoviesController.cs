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
        //public ActionResult Random()
        //{
        //    List<Movie> movies = new List<Movie>
        //    {
        //        new Movie { Name = "Alien"},
        //        new Movie { Name = "Shrek"},
        //        new Movie { Name = "The Last Jedi"},
        //        new Movie { Name = "Pocahontas"},
        //        new Movie { Name = "Interstellar"}
        //    };

        //    return View(movies[new Random().Next(0, 5)]);
        //}

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        public ActionResult Foo(int arg)
        {
            if (arg % 2 == 0)
                return RedirectToAction("Edit", "Movies", new { id = arg });
            else
                return Redirect("http://google.com");
        }

        public ActionResult Index( int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue) pageIndex = 1;
            if (string.IsNullOrEmpty(sortBy)) sortBy = "Name";

            return Content(string.Format("pageIndex = {0}, sortBy = {1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate( int? year, int? month)
        {
            if (!year.HasValue) year = 2000;
            if (!month.HasValue) month = 1;

            return Content(string.Format("Date: {0}/{1}", month, year));
        }

        public ViewResult Random()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"},
                new Customer { Name = "Customer 3"}
            };

            var movie = new Movie
            {
                Name = "The Last Jedi"
            };

            var VM = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(VM);
        }

    }
}