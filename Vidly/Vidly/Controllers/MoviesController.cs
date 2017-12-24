using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

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
            var movies = _Context.Movies.ToList();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _Context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        public ViewResult New()
        {
            var VM = new MovieFormViewModel
            {
                Genres = _Context.Genres.ToList()
            };

            return View("MovieForm", VM);
        }

        [HttpPost]
        public RedirectToRouteResult Save( Movie movie)
        {
            if (movie.Id == 0)
            {
                movie.AddedDate = DateTime.Now.ToString();
                _Context.Movies.Add(movie);
            }
            else
            {
                var movieInDB = _Context.Movies.Single(m => m.Id == movie.Id);

                movieInDB.Name = movie.Name;
                movieInDB.ReleaseDate = movie.ReleaseDate;
                movieInDB.GenreId = movie.GenreId;
                movieInDB.NumberInStock = movie.NumberInStock;
            }

            _Context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }
    }
}