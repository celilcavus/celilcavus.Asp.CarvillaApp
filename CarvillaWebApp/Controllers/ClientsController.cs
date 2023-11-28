using _01.Entity;
using _03.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarvillaWebApp.Controllers
{
    public class ClientsController : Controller
    {
        private readonly IClientsRepository _clientsRepository;

        public ClientsController(IClientsRepository clientsRepository)
        {
            _clientsRepository = clientsRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Clients clients)
        {
            Clients c = new Clients();
            c.FileName = clients.Image.FileName;
            c.Description = clients.Description;
            c.Name = clients.Name;
            c.LastName = clients.LastName;
            c.Location = clients.Location;
            c.IsActive = clients.IsActive;
            _clientsRepository.Add(c);
            _clientsRepository.ImageUpload(clients.Image,"Clients");
            return View();
        }
       
    }
}
