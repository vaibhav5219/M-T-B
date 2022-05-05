using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTicketbookingModel;

namespace MovieTicketbookingDataLayer
{
    public class MovieDbOperation
    {
        private Vaibhav_test_dbEntities _context;

        public MovieDbOperation()
        {
            _context = new Vaibhav_test_dbEntities();
        }
        public IEnumerable<Movie> GetAllMoviesList()
        {
            IEnumerable<Movie> movies = _context.Movies1.ToList();
            return movies;
        }
        public Movie GetMovie(int id)
        {
            Movie movie = _context.Movies1.SingleOrDefault(m => m.Id == id);
            return movie;
        }
        public void CreateMovie(Movie movie)
        {
            _context.Movies1.Add(movie);
            _context.SaveChanges();
            
        }
    }
}
