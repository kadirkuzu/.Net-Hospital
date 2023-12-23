namespace Hospital.Models.Hospital.ResponseDto
{
    public class ClinicResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public IEnumerable<DoctorDto> Doctors { get; set; }

        public ClinicResponseDto(Clinic clinic)
        {
            Id = clinic.Id;
            Name = clinic.Name;
            DepartmentId = clinic.Department!.Id;
            DepartmentName = clinic.Name;
            Doctors = clinic.Doctors?.Select(x => new DoctorDto(x)) ?? new List<DoctorDto>();
        }
    }
}
