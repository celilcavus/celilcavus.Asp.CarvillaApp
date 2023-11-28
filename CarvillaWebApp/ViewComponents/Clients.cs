using _03.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarvillaWebApp.ViewComponents
{
    public class Clients:ViewComponent
    {
        private readonly IClientsRepository clientsRepository;

        public Clients(IClientsRepository clientsRepository)
        {
            this.clientsRepository = clientsRepository;
        }

        public IViewComponentResult Invoke()
        {
            var values = clientsRepository.GetAll();
            return View(values);
        }
    }
}
