using MovieTicketbookingModel;
using MovieTicketbookingDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketbookingBusinessLogic
{
    public class BookingBL
    {
        public IEnumerable<Booking> GetAllBookingList()
        {
            var objBookingDbOperation = new BookingDbOperation();
            return objBookingDbOperation.GetAllBookingList();
        }
        public void SaveCustomer(Booking booking)
        {
            var bookingdata = new BookingDbOperation();
            bookingdata.SaveBooking(booking);
        }
        public Movie GetMovieByName(int id)
        {
            var bookingDbOperationObj = new BookingDbOperation();
            return bookingDbOperationObj.GetMovieName(id);
        }
    }
}
