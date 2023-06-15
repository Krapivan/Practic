using Microsoft.AspNetCore.Mvc;
using practic.Models;
using RegistryProject.Models;


namespace practic.Controllers
{
    public class HomeController : Controller
    {
        public static string _rule;
       
        private ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        

        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Main(string username, string password)
        {
            List<Admin> admin = DataBaseFunctions.GetAdmins(db);
            for (int i = 0; i < admin.Count; i++)
            {
                if (admin[i].Login == username && admin[i].Password == password)
                {
                    if (admin[i].CanChangeProfiles == true && admin[i].CanChangeDoctors == true)
                    {
                        _rule = "admin_main";
                    }
                    else if (admin[i].CanChangeProfiles == true && admin[i].CanChangeDoctors == false)
                    {
                        _rule = "admin_prof";
                    }
                    else if (admin[i].CanChangeProfiles == false && admin[i].CanChangeDoctors == true)
                    {
                        _rule = "admin_doc";
                    }
                    return View();
                }
            }

            List<User> user = DataBaseFunctions.GetUsers(db);
            for (int i = 0; i < user.Count; i++)
            {
                if (user[i].Login == username && user[i].Password == password)
                {
                    return View();
                }
            }

            ViewBag.Message = "Wrong Login or Password";
            return View("Login");
        }

        [HttpGet]
        public IActionResult Patients()
        {
            List<Patient> patient = DataBaseFunctions.GetPatients(db); // Получение списка пациентов из базы данных

            ViewBag.Patients = patient; // Установка значения ViewBag.Patients

            return View();
        }

        [HttpGet]
        public IActionResult Doctors()
        {
            List<Doctor> doctor = DataBaseFunctions.GetDoctors(db); // Получение списка пациентов из базы данных

            ViewBag.Doctors = doctor; // Установка значения ViewBag.Patients

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