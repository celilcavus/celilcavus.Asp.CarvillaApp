using Microsoft.AspNetCore.Mvc;

namespace CarvillaWebApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Admin()
        {
            return View();
        }
    }
}
