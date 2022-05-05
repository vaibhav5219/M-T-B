using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTicketbookingDataLayer;
using MovieTicketbookingModel;

namespace MovieTicketbookingBusinessLogic
{
    public class MovieBL
    {
        MovieDbOperation movieobj = new MovieDbOperation();

        public IEnumerable<Movie> GetAllMoviesList()
        {
            return movieobj.GetAllMoviesList();
        }
        public Movie GetMovie(int id)
        {
            return movieobj.GetMovie(id);
        }
        public void CreateMovie(Movie movie)
        {
            movieobj.CreateMovie(movie);
        }
        
    }
}
