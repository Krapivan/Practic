using System.ComponentModel.DataAnnotations;

namespace RegistryProject.Models
{
    public class Ticket
    {
        [Key] public int Id { get; set; }
        public string PatientFIO { get; set; }
        public string DoctorFIO { get; set; }
        public DateTime DateTimeTicket { get; set; }
    }
}
