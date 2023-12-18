using Hospital.Models.Common;

namespace Hospital.Models
{
    public class Patient : Person
    {
        public ICollection<Appointment>? Appointments { get; set; }

    }
}
