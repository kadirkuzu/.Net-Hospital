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
        public int DoctorCount { get; set; }
        public DepartmentClinic(Clinic clinic)
        {
            Id = clinic.Id;
            Name = clinic.Name;
            DoctorCount = clinic.Doctors != null ? clinic.Doctors.Count() : 0;
        }
        public DepartmentClinic()
        {
            
        }
    }
}
