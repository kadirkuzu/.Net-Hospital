namespace Hospital.Models.Hospital.ResponseDto
{
    public class GetAppointmentResponseDto
    {
        public Guid Id { get; set; }
        public Guid DoctorId { get; set; }
        public string DoctorName { get; set; }
        public Guid PatientId { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan Time { get; set; }

        public GetAppointmentResponseDto(Appointment appointment)
        {
            Id = appointment.Id;
            DoctorId = appointment.DoctorId;
            DoctorName = appointment.Doctor.Name;
            PatientId = appointment.PatientId;
            Day = appointment.Day;
            Time = appointment.Time;
        }
        public GetAppointmentResponseDto()
        {
            
        }
    }
}
