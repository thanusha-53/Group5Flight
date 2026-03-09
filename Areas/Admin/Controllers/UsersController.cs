using Microsoft.AspNetCore.Mvc;

namespace Group5Flight.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        // Dashboard (returns a View)
        public IActionResult Index()
        {
            return View();
        }

        // Manage users (routing test)
        public IActionResult Manage()
        {
            return Content("Admin managing users");
        }

        // Rights & Obligations (routing test)
        public IActionResult Rights()
        {
            return Content("Admin rights and obligations");
        }
    }
}