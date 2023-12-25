using Appointments.Data;
using Appointments.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Appointments.Controllers
{
    public class MarcacaoController : Controller
    {
        private readonly ILogger<MarcacaoController> _logger;

        public MarcacaoController(ILogger<MarcacaoController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        public IActionResult Book()
        {
            return View();
        }

        public class ApplicationUser : IdentityUser
        {
            public ICollection<Appointment> Appointments { get; set; }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}
