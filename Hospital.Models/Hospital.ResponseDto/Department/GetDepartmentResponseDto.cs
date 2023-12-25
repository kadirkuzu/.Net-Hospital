namespace Hospital.Models.Hospital.ResponseDto
{
    public class GetDepartmentResponseDto
    {
        public string Name { get; set; }
        public IEnumerable<DepartmentClinic> Clinics { get; set; }
        public GetDepartmentResponseDto(Department department)
        {
            Name = department.Name;
            Clinics = department.Clinics!=null ? department.Clinics.Select(x => new DepartmentClinic(x)) : new List<DepartmentClinic>();
        }
    }

    public class DepartmentClinic
    {
        public string Name { get; set; }
        public IEnumerable<Doctor> Doctors { get; set; }
        public DepartmentClinic(Clinic clinic)
        {
            Name = clinic.Name;
            Doctors = clinic.Doctors ?? new List<Doctor>();
        }
    }
}
