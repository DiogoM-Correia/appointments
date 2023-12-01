using Microsoft.AspNetCore.Identity;

namespace Appointments.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
