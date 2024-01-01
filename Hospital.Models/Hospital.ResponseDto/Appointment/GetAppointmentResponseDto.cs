namespace Hospital.Models.Hospital.ResponseDto
{
    public class GetAppointmentResponseDto
    {
        public Guid Id { get; set; }
        public Guid DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string PatientName { get; set; }
        public Guid PatientId { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan Time { get; set; }

        public GetAppointmentResponseDto(Appointment appointment)
        {
            Id = appointment.Id;
            DoctorId = appointment.DoctorId;
            DoctorName = appointment.Doctor.Name + " " + appointment.Doctor.Surname;
            PatientName = appointment.Patient != null ? appointment.Patient.UserName : "";
            PatientId = appointment.PatientId;
            Day = appointment.Day;
            Time = appointment.Time;
        }
        public GetAppointmentResponseDto()
        {
            
        }
    }
}
