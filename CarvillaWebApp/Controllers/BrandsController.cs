using _01.Entity;
using _03.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarvillaWebApp.Controllers
{
    public class BrandsController : Controller
    {
        private readonly IBrandsRepository _brandsRepository;
        private  Brands b = new Brands();
		public BrandsController(IBrandsRepository brandsRepository)
        {
            _brandsRepository = brandsRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(Brands brands)
        {
            b.FileName = brands.Image.FileName; 
            b.IsActive = brands.IsActive;
            _brandsRepository.Add(b);
            _brandsRepository.ImageUpload(brands.Image,"Brands");

            return View();
        }
    }
}
