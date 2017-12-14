using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Random()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie { Name = "Alien"},
                new Movie { Name = "Shrek"},
                new Movie { Name = "The Last Jedi"},
                new Movie { Name = "Pocahontas"},
                new Movie { Name = "Interstellar"}
            };

            return View(movies[new Random().Next(0, 5)]);
        }
    }
}