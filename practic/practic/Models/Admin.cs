using System.ComponentModel.DataAnnotations;

namespace RegistryProject.Models
{
    public class Admin
    {
        [Key] public int Id {  get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool CanChangeProfiles { get; set; }
        public bool CanChangeDoctors { get; set; }
    }
}
