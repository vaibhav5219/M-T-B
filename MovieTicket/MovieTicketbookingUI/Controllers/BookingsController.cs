using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieTicketbookingBusinessLogic;
using MovieTicketbookingModel;

namespace MovieTicketbookingUI.Controllers
{
    public class BookingsController : Controller
    {
        public ActionResult Index()
        {
            var objbl = new BookingBL();
            IEnumerable<Booking> bookings = objbl.GetAllBookingList();
            return View("BookingsList", bookings);
        }
        public ActionResult SeatsAvailable()
        {
            return View();
        }
    }
}