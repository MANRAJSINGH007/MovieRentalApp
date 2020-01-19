using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{

    public class MoviesController : Controller
    {
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
        {
            new Movie {Id = 1, Name = "Shrek"},
            new Movie {Id = 2, Name = "Wall-e"}
        };
        }
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            //return View(movie);
            //return Content("Hello World");
            // return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name"});
            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model = movie;
            //return viewResult;
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer1" },
                new Customer { Name = "Customer2" }
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers

            };
            return View(viewModel);
        }
        
    }
}