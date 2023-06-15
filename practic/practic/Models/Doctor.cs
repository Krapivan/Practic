using System.ComponentModel.DataAnnotations;

namespace RegistryProject.Models
{
    public class Doctor
    {
       
       [Key] public string FIO { get; set; }
        public string Post { get; set; }
        public int RoomNumber { get; set; }
        public TimeOnly WorkTime { get; set; } 

    }
}
