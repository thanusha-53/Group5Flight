using Microsoft.AspNetCore.Mvc;

namespace Group5Flight.Areas.Airline.Controllers
{
    [Area("Airline")]
    public class FlightsController : Controller
    {
        // Airline Dashboard
        public IActionResult Index()
        {
            // Decide what Index should do: show view or redirect
            // Option 1: show the dashboard view
            return View();  

            // Option 2: redirect to Manage instead
            // return RedirectToAction("Manage");
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