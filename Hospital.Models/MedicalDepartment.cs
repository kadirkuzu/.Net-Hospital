using Hospital.Models.Common;

namespace Hospital.Models
{
    public class MedicalDepartment : BaseEntity
    {
        public string Name { get; set; }
        public MedicalDepartment(string name)
        {
            Name = name;
        }
    }
}
