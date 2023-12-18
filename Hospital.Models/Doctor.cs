using Hospital.Models.Common;

namespace Hospital.Models
{
    public class Doctor : Person
    {
        public Guid ClinicId { get; set; }
        public Clinic? Clinic { get; set; }
        public ICollection<WorkSchedule>? WorkSchedules { get; set; }
    }
}
