namespace Hospital.Models.Hospital.ResponseDto
{
    public class GetClinicResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public IEnumerable<GetDoctorResponseDto> Doctors { get; set; }

        public GetClinicResponseDto(Clinic clinic)
        {
            Id = clinic.Id;
            Name = clinic.Name;
            DepartmentId = clinic.Department!.Id;
            DepartmentName = clinic.Name;
            Doctors = clinic.Doctors?.Select(x => new GetDoctorResponseDto(x)) ?? new List<GetDoctorResponseDto>();
        }
        public GetClinicResponseDto()
        {
            
        }
    }
}
