using RegistryProject.Models;

namespace practic.Models
{
    public static class DataBaseFunctions
    {

        public static List<User> GetUsers(ApplicationContext db)
        {
            return db.Users.ToList();
        }
        public static List<Admin> GetAdmins(ApplicationContext db)
        {
            return db.Admins.ToList();
        }
        public static List<Patient> GetPatients(ApplicationContext db)
        {
            return db.Patients.ToList();
        }
        public static List<Ticket> GetTickets(ApplicationContext db)
        {
            return db.Tickets.ToList();
        }
        public static List<Doctor> GetDoctors(ApplicationContext db)
        {
            return db.Doctors.ToList();
        }
    }
}
