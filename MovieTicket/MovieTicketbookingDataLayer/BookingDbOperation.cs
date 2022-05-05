using MovieTicketbookingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Data.Entity;

namespace MovieTicketbookingDataLayer
{
    public class BookingDbOperation
    {
        private Vaibhav_test_dbEntities _context;

        public BookingDbOperation()
        {
            _context = new Vaibhav_test_dbEntities();
        }

        public IEnumerable<Booking> GetAllBookingList()
        {
            var objBooking = _context.Bookings1.Include(m => m.Movie).Include(c => c.Customer).ToList();
            return objBooking;
        }

        //save booking
        public void SaveBooking(Booking booking)
        {
            Movie movie = _context.Movies1.Single(m => m.Id == booking.Movie.Id);

            if (movie.SeatsAvailable<1)
            {
                return ;
            }
            var bookingInDb = new Booking()
            {
                Mid = booking.Movie.Id,
                Customer = new Customer() { Mobile = booking.Customer.Mobile, Name = booking.Customer.Name },
                SeatNo = booking.SeatNo,
            };

            movie.SeatsAvailable--;

            _context.Bookings1.Add(bookingInDb);
            _context.SaveChanges();
            
            // if (customer.Cid == 0)
            //     _context.Customers.Add(customer);
            // else
            // {
            //var customerInDb = _context.Customers.SingleOrDefault(c => c.Cid == customer.Cid);
            //customerInDb.Name = customer.Name;

            //customerInDb.Mobile = customer.Mobile;
            //_context.Customers.Add(customerInDb);
            // }
            //_context.SaveChanges();

        }
        public Movie GetMovieName(int id)
        {
            var movie =  _context.Movies1.Single(m => m.Id == id);
            return movie;
        }
    }
}
