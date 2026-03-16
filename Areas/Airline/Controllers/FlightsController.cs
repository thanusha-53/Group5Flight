using Microsoft.AspNetCore.Mvc;

namespace Group5Flight.Areas.Airline.Controllers
{
    [Area("Airline")]
    public class FlightsController : Controller
    {
<<<<<<< HEAD
=======
<<<<<<< HEAD
        // Airline Dashboard
        public IActionResult Index()
        {
            return View();  // loads Index.cshtml
        }

        // Manage flights
        public IActionResult Manage()
        {
            return Content("Airline managing flights");
        }

        // Regulation page (optional)
        public IActionResult Regulation()
        {
            return Content("Airline regulations");
        }
=======
>>>>>>> cd2ce3cfe5472f433741ae167933c3f4f5fea2ce
        public IActionResult Index()
    {
        return RedirectToAction("Manage");
    }
        public IActionResult Manage()
    {
        return Content("Airline Manage Flights Page");
    }

<<<<<<< HEAD
=======
>>>>>>> 30118906f581719ecf98770c296a8907428a3225
>>>>>>> cd2ce3cfe5472f433741ae167933c3f4f5fea2ce
    }
}