using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Privacy(string username, string password)
        {
            var a = db.Admins.ToList();
            ViewBag.username = a[0].Login;
            
            
            return View();
        }

      
    }
}