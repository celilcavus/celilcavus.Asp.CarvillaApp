using _03.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarvillaWebApp.ViewComponents
{
    public class Brands : ViewComponent
    {
        private readonly IBrandsRepository brandsRepository;

        public Brands(IBrandsRepository brandsRepository)
        {
            this.brandsRepository = brandsRepository;
        }

        public IViewComponentResult Invoke()
        {
            var value = brandsRepository.GetAll();
            return View(value);
        }
    }
}
