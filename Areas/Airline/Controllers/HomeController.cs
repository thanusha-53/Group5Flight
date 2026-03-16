using Microsoft.AspNetCore.Mvc;

namespace Group5Flight.Areas.Airline.Controllers
{
    [Area("Airline")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Regulation()
        {
            return Content("Airline Regulation Page");
        }
    }
}