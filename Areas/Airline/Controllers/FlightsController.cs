using Microsoft.AspNetCore.Mvc;

namespace Group5Flight.Areas.Airline.Controllers
{
    [Area("Airline")]
    public class FlightsController : Controller
    {
        public IActionResult Index()
    {
        return RedirectToAction("Manage");
    }
        public IActionResult Manage()
    {
        return Content("Airline Manage Flights Page");
    }

    }
}