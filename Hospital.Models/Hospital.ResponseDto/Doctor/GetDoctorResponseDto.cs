namespace Hospital.Models.Hospital.ResponseDto
{
    public class GetDoctorResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Guid ClinicId { get; set; }
        public string ClinicName { get; set; }
        public IEnumerable<DoctorWorkSchedule> WorkSchedules { get; set; }

        public GetDoctorResponseDto(Doctor doctor)
        {
            Id = doctor.Id;
            Name = doctor.Name;
            Surname = doctor.Surname;
            Email = doctor.Email;
            Phone = doctor.Phone;
            ClinicId = doctor.ClinicId;
            ClinicName = doctor.Clinic!.Name;
            WorkSchedules = doctor.WorkSchedules?.Select(x=>new DoctorWorkSchedule(x)) ?? new List<DoctorWorkSchedule>();
        }

        public GetDoctorResponseDto()
        {

        }
    }
    public class DoctorWorkSchedule
    {
        public Guid Id { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public DoctorWorkSchedule(WorkSchedule ws)
        {
            Id = ws.Id;
            Day = ws.Day;
            StartTime = ws.StartTime;
            EndTime = ws.EndTime;
        }
        public DoctorWorkSchedule()
        {
            
        }
    }
}
