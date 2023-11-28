using _01.Entity;
using _03.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarvillaWebApp.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IServicesRepository _servicesRepository;
        public ServicesController(IServicesRepository servicesRepository)
        {
            _servicesRepository = servicesRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Services services)
        {
            Services services1 = new();
            services1.Title = services.Title;
            services1.Description = services.Description;
            services1.ImageName = services.Image.FileName;
            services1.IsActive = services.IsActive;
            _servicesRepository.Add(services1);
            _servicesRepository.ImageUpload(services.Image, "Services");
            return View();
        }
    }
}
