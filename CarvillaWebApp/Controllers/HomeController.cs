using Microsoft.AspNetCore.Mvc;

namespace CarvillaWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
