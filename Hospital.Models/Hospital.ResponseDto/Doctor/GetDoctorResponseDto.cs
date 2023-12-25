namespace Hospital.Models.Hospital.ResponseDto
{
    public class GetDoctorResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; }
        public string SurName { get; }
        public string Email { get; }
        public string Phone { get; }
        public Guid ClinicId { get; }
        public string ClinicName { get; }
        public IEnumerable<WorkSchedule> WorkSchedules { get; set; }
        public GetDoctorResponseDto(Doctor doctor)
        {
            Id = doctor.Id;
            Name = doctor.Name;
            SurName = doctor.Surname;
            Email = doctor.Email;
            Phone = doctor.Phone;
            ClinicId = doctor.ClinicId;
            ClinicName = doctor.Clinic!.Name;
            WorkSchedules = doctor.WorkSchedules ?? new List<WorkSchedule>();
        }
    }
}
