using System.ComponentModel.DataAnnotations;

namespace RegistryProject.Models
{
    public class Patient
    {
        [Key] public int Id { get; set; }
        public string FIO { get; set; }

        public string Adress { get; set; }

        public string Phone { get; set; }
        public DateOnly DateBirthdat { get; set; }

    }
}
