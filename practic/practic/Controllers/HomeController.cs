using Microsoft.AspNetCore.Mvc;
using practic.Models;
using RegistryProject.Models;


namespace practic.Controllers
{
    public class HomeController : Controller
    {
       
        private ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Patients(string username, string password)
        {
            List<Patient> patients = DataBaseFunctions.GetPatients(db); // Получение списка пациентов из базы данных

            ViewBag.Patients = patients; // Установка значения ViewBag.Patients

            return View();
        }
        [HttpGet]
        public IActionResult Tickets()
        {
            List<Ticket> Tickets = DataBaseFunctions.GetTickets(db); // Получение списка пациентов из базы данных

            ViewBag.Tickets = Tickets; // Установка значения ViewBag.Patients

            return View();
        }

    }
}