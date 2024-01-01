namespace Hospital.Models.Hospital.RequestDto.Appointment
{
    public class AddAppointmentRequestDto
    {
        public Guid? DepartmentId { get; set; }
        public Guid? ClinicId { get; set; }
        public Guid? DoctorId { get; set; }
        public DayOfWeek? Day { get; set; }
        public TimeSpan? Time { get; set; }
    }
}
