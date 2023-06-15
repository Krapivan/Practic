using Microsoft.AspNetCore.Mvc;
using practic.Models;
using RegistryProject.Models;


namespace practic.Controllers
{
    public class HomeController : Controller
    {
        public static string _role = "";
       
        private ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        

        public IActionResult Login()
        {
            if (_role == "")
                return View();
            else
            {
                ViewBag.role = _role;
                return View(Main);
            }
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
                       
                        _role = "admin_main";
                    }
                    else if (admin[i].CanChangeProfiles == true && admin[i].CanChangeDoctors == false)
                    {
                        _role = "admin_prof";
                    }
                    else if (admin[i].CanChangeProfiles == false && admin[i].CanChangeDoctors == true)
                    {
                        _role = "admin_doc";
                    }
                    ViewBag.role = _role;
                    return View();
                }
            }

            List<User> user = DataBaseFunctions.GetUsers(db);
            for (int i = 0; i < user.Count; i++)
            {
                if (user[i].Login == username && user[i].Password == password)
                {
                    _role = "user";
                    ViewBag.role = _role;
                    return View();
                }
            }

            ViewBag.Message = "Wrong Login or Password";
            return View("Login");
        }

        [HttpGet]
        public IActionResult Patients()
        {
            List<Patient> patient = DataBaseFunctions.GetPatients(db); 

            ViewBag.Patients = patient; 

            return View();
        }

        [HttpGet]
        public IActionResult Doctors()
        {
            List<Doctor> doctor = DataBaseFunctions.GetDoctors(db); 

            ViewBag.Doctors = doctor; 

            return View();
        }

        [HttpGet]
        public IActionResult Tickets()
        {
            List<Ticket> Tickets = DataBaseFunctions.GetTickets(db); 

            ViewBag.Tickets = Tickets; 

            return View();
        }

    }
}