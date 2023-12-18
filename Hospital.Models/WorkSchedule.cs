using Hospital.Models.Common;

namespace Hospital.Models
{
    public class WorkSchedule : BaseEntity
    {
        public Guid DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
