using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieTicketbookingBusinessLogic;
using MovieTicketbookingModel;

namespace MovieTicketbookingUI.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var objbl = new MovieBL();
            IEnumerable<Movie> movies = objbl.GetAllMoviesList();
            return View("MoviesList",movies);
        }
        public ActionResult MovieDetails(int id)
        {
            var objbl = new MovieBL();
            Movie movie = objbl.GetMovie(id);
            return View("MovieDetails", movie);
        }
        public ActionResult CreateMovie()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateMovie(Movie movie)
        {
            var objbl = new MovieBL();
            objbl.CreateMovie(movie);
            return View("MoviesList","Movies");
        }
    }
}