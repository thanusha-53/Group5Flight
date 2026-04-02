using Group5Flight.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Group5Flight.Controllers
{
    public class HomeController : Controller
    {
        private readonly AirBnBContext _context;

        public HomeController(AirBnBContext context)
        {
            _context = context;
        }

        // HOME PAGE (GET)
        public IActionResult Index()
        {
            var flights = _context.Flights
                .Include(f => f.Airline)
                .AsQueryable();

            var from = HttpContext.Session.GetString("From");
            var to = HttpContext.Session.GetString("To");
            var cabin = HttpContext.Session.GetString("CabinType");
            var dateStr = HttpContext.Session.GetString("Date");
            var airlineIdStr = HttpContext.Session.GetString("AirlineId");

            if (!string.IsNullOrEmpty(from))
                flights = flights.Where(f => f.From == from);

            if (!string.IsNullOrEmpty(to))
                flights = flights.Where(f => f.To == to);

            if (!string.IsNullOrEmpty(cabin) && cabin != "All")
                flights = flights.Where(f => f.CabinType == cabin);

            if (!string.IsNullOrEmpty(dateStr))
            {
                var date = DateTime.Parse(dateStr);
                flights = flights.Where(f => f.Date == date);
            }

            if (!string.IsNullOrEmpty(airlineIdStr))
            {
                int id = int.Parse(airlineIdStr);
                flights = flights.Where(f => f.AirlineId == id);
            }

            var vm = new HomeViewModel
            {
                Flights = flights.ToList(),
                From = from ?? "",
                To = to ?? "",
                CabinType = cabin ?? "All",
                DepartureDate = string.IsNullOrEmpty(dateStr)
                    ? DateTime.Now.AddDays(1)
                    : DateTime.Parse(dateStr),
                Airlines = _context.Airlines.ToList(),
                AirlineId = string.IsNullOrEmpty(airlineIdStr) ? null : int.Parse(airlineIdStr),

                FromCities = _context.Flights.Select(f => f.From).Distinct().ToList(),
                ToCities = _context.Flights.Select(f => f.To).Distinct().ToList(),

                CabinTypes = new List<string>
                {
                    "All", "Basic Economy", "Economy", "Economy Plus", "Business"
                }
            };

            return View(vm);
        }

        // FILTER (POST → PRG)
        [HttpPost]
        public IActionResult Filter(HomeViewModel vm)
        {
            HttpContext.Session.SetString("From", vm.From ?? "");
            HttpContext.Session.SetString("To", vm.To ?? "");
            HttpContext.Session.SetString("CabinType", vm.CabinType ?? "All");
            HttpContext.Session.SetString("AirlineId", vm.AirlineId?.ToString() ?? "");

            if (vm.DepartureDate.HasValue)
                HttpContext.Session.SetString("Date", vm.DepartureDate.Value.ToString("yyyy-MM-dd"));

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return Content("Client privacy page");
        }

        public IActionResult TestRouting()
        {
            return Content("Routing test works!");
        }

        // 🔥 ADD THESE INSIDE CLASS

        public IActionResult Details(int id)
        {
            var flight = _context.Flights
                .Include(f => f.Airline)
                .FirstOrDefault(f => f.FlightId == id);

            return View(flight);
        }

        [HttpPost]
        public IActionResult Select(int id)
        {
            var selected = HttpContext.Session.GetString("SelectedFlights");

            List<int> selectedList;

            if (string.IsNullOrEmpty(selected))
            {
                selectedList = new List<int>();
            }
            else
            {
                selectedList = selected.Split(',').Select(int.Parse).ToList();
            }

            if (!selectedList.Contains(id))
            {
                selectedList.Add(id);
            }

            HttpContext.Session.SetString("SelectedFlights", string.Join(",", selectedList));

            TempData["Message"] = "Flight selected successfully!";

            return RedirectToAction("Index");
        }
    }
}