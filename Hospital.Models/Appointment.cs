using Hospital.Models.Common;
using Hospital.Models.Hospital.RequestDto.Appointment;

namespace Hospital.Models
{
    public class Appointment : BaseEntity
    {
        public Guid PatientId { get; set; }
        public Patient? Patient { get; set; }
        public Guid DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan Time { get; set; }
        public bool IsApproved { get; set; }
        public Appointment()
        {
            
        }
        public Appointment(AddAppointmentRequestDto request,Guid patientId)
        {
            PatientId = patientId;
            DoctorId = request.DoctorId ?? new Guid() ;
            Day = request.Day ?? new DayOfWeek() ;
            Time = request.Time ?? new TimeSpan();
        }
    }
}
