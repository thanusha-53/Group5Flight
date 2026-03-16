using Microsoft.AspNetCore.Mvc;

namespace Group5Flight.Controllers
{
    public class HomeController : Controller
    {
        // Client Dashboard
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search()
        {
            return Content("Client searching flights");
        }

        public IActionResult Privacy()
        {
            return Content("Client privacy page");
        }
    }
}
