using _01.Entity;
using _03.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarvillaWebApp.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarsRepository carsRepository;

        public CarsController(ICarsRepository carsRepository)
        {
            this.carsRepository = carsRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Cars cars)
        {
            Cars cars1 = new Cars();
            cars1.ImageName = cars.Image.FileName;
            cars1.Name = cars.Name;
            cars1.Price = cars.Price;
            cars1.PriceIcon = cars.PriceIcon;
            cars1.Description = cars.Description;
            cars1.IsActive = cars.IsActive;
            cars1.Model = cars.Model;
            carsRepository.Add(cars1);
            carsRepository.ImageUpload(cars.Image,"Cars");
            return View();
        }
    }
}
