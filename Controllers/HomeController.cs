<<<<<<< HEAD
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Group5Flights.Models;

namespace Group5Flights.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
=======
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
>>>>>>> cd2ce3cfe5472f433741ae167933c3f4f5fea2ce
