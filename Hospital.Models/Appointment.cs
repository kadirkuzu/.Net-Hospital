using Hospital.Models.Common;

namespace Hospital.Models
{
    public class Appointment : BaseEntity
    {
        public Guid PatientId { get; set; }
        public Patient? Patient { get; set; }
        public Guid DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public bool IsApproved { get; set; }
    }
}
