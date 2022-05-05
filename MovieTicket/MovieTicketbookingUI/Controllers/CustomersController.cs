using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MovieTicketbookingBusinessLogic;
using MovieTicketbookingModel;
using System.Data.Entity;
using MovieTicketbookingUI.ViewModel;

namespace MovieTicketbookingUI.Controllers
{
    public class CustomersController:Controller
    {
        public ActionResult AddCustomer(int id)
        {
            var bookingObj = new BookingBL();
            Movie movie = bookingObj.GetMovieByName(id);

            var booking = new Booking()
            {
                Movie = new Movie() 
                { 
                    Id=id,Name=movie.Name,
                    ReleaseDate=movie.ReleaseDate,
                    SeatsAvailable=movie.SeatsAvailable
                },
                Customer = new Customer() { },
                SeatNo = 100
            };
            return View("AddCustomerForm",booking);
        }

        [HttpPost]
        public ActionResult SaveCustomer(Booking booking)
        {
            var bookingObj = new BookingBL();
            bookingObj.SaveCustomer(booking);
            return RedirectToAction("Index","Movies");
        }
    }
}