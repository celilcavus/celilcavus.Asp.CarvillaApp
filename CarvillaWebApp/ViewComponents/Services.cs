using _03.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarvillaWebApp.ViewComponents
{
    public class Services:ViewComponent
    {
        private readonly IServicesRepository _servicesRepository;

        public Services(IServicesRepository servicesRepository)
        {
            _servicesRepository = servicesRepository;
        }

        public IViewComponentResult Invoke()
        {

            var values = _servicesRepository.GetAll();
            return View(values);
        }
    }
}
