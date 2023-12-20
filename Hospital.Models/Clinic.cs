using Hospital.Models.Common;

namespace Hospital.Models
{
    public class Clinic : BaseEntity
    {
        public string Name { get; set; }
        public Guid DepartmentId { get; set; }
        public Department? Department { get; set; }
        public ICollection<Doctor>? Doctors { get; set; }
        public Clinic(string name, Guid departmentId)
        {
            Name = name;
            Id = Guid.NewGuid();
            DepartmentId = departmentId;
        }
        public Clinic(Guid id , string name , Guid departmentId)
        {
            Id = id;
            Name = name;
            DepartmentId = departmentId;
        }
    }
    public class AddClinicRequest
    {
           public string Name { get; set; }
           public Guid DepartmentId { get; set; }
    }
    public class ClinicDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public IEnumerable<DoctorDto> Doctors { get; set; }

        public ClinicDto(Clinic clinic)
        {
            Id = clinic.Id;
            Name=clinic.Name;
            DepartmentId = clinic.Department!.Id;
            DepartmentName = clinic.Name;
            Doctors = clinic.Doctors?.Select(x=> new DoctorDto(x)) ?? new List<DoctorDto>();
        }
    }
}
