namespace Hospital.Models.Hospital.ResponseDto
{
    public class GetClinicResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public IEnumerable<ClinicDoctor> Doctors { get; set; }

        public GetClinicResponseDto(Clinic clinic)
        {
            Id = clinic.Id;
            Name = clinic.Name;
            DepartmentId = clinic.Department!.Id;
            DepartmentName = clinic.Department.Name;
            Doctors = clinic.Doctors?.Select(x => new ClinicDoctor(x)) ?? new List<ClinicDoctor>();
        }
        public GetClinicResponseDto()
        {
            
        }
    }
    public class ClinicDoctor
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public ClinicDoctor()
        {
            
        }
        public ClinicDoctor(Doctor doctor)
        {
            FullName = doctor.Name + " " + doctor.Surname;
            Name = doctor.Name;
            Surname = doctor.Surname;
            Phone = doctor.Phone;
            Email = doctor.Email;
            Id = doctor.Id;
        }
    }
}
