using Hospital.Models.Common;
using System.Xml.Linq;

namespace Hospital.Models
{
    public class WorkSchedule : BaseEntity
    {
        public ICollection<Doctor>? Doctors { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public WorkSchedule(Guid id, DayOfWeek day, TimeSpan startTime, TimeSpan endTime)
        {
            Id = id;
            Day = day;
            StartTime = startTime;
            EndTime = endTime;
            Doctors = new List<Doctor>();
        }
    }
}
