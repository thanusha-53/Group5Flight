using Microsoft.AspNetCore.Mvc;

namespace Group5Flight.Areas.Airline.Controllers
{
    [Area("Airline")]
    public class FlightsController : Controller
    {
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
    }
}