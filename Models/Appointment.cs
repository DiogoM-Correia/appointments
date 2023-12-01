namespace Appointments.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string UserId { get; set; } // Foreign key for user
        //public ApplicationUser User { get; set; }
    }
}
