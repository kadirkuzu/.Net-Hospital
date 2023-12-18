using Hospital.Models.Common;

namespace Hospital.Models
{
    public class Clinic : BaseEntity
    {
        public string Name { get; set; }
        public Guid DepartmentId { get; set; }
        public MedicalDepartment? Department { get; set; }
        public Clinic(string name) {
            Name = name;
        }

    }
}
