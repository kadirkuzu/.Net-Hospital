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
}
