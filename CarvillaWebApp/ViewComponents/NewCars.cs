using _03.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarvillaWebApp.ViewComponents
{
    public class NewCars : ViewComponent
    {
        private readonly ICarsRepository carsRepository;

        public NewCars(ICarsRepository carsRepository)
        {
            this.carsRepository = carsRepository;
        }

        public IViewComponentResult Invoke()
        {
            var values = carsRepository.GetAll().TakeLast(3).ToList();
            return View(values);
        }
    }
}
