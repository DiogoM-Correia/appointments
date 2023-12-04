using Appointments.Data;
using Appointments.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Appointments.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AppointmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult Index()
        {
            string userStringId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var userAppointments = _context.Appointments
                .Where(a => a.User.Id == userStringId)
                .ToList();

            return View(userAppointments);
        }

        [Authorize]
        public IActionResult Book()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AdminIndex()
        {
            var allAppointments = _context.Appointments.ToList();
            return View(allAppointments);
        }

        public class ApplicationUser : IdentityUser
        {
            public ICollection<Appointment> Appointments { get; set; }
        }

        // Other actions...
    }

}
