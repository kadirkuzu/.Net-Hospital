namespace Hospital.Models.Hospital.ResponseDto
{
    public class GetDepartmentResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<DepartmentClinic> Clinics { get; set; }
        public GetDepartmentResponseDto(Department department)
        {
            Id = department.Id;
            Name = department.Name;
            Clinics = department.Clinics != null ? department.Clinics.OrderByDescending(x=>x.CreatedDate).Select(x => new DepartmentClinic(x)) : new List<DepartmentClinic>();
        }
        public GetDepartmentResponseDto()
        {

        }
    }

    public class DepartmentClinic
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Doctor> Doctors { get; set; }
        public DepartmentClinic(Clinic clinic)
        {
            Id = clinic.Id;
            Name = clinic.Name;
            Doctors = clinic.Doctors ?? new List<Doctor>();
        }
        public DepartmentClinic()
        {
            
        }
    }
}
