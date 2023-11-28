using _03.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarvillaWebApp.ViewComponents
{
    public class Cars:ViewComponent
    {
        private readonly ICarsRepository carsRepository;

		public Cars(ICarsRepository carsRepository)
		{
			this.carsRepository = carsRepository;
		}

		public IViewComponentResult Invoke()
        {
            var values = carsRepository.GetAll();
            return View(values);
        }
    }
}
