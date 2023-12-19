using Hospital.Models.Common;

namespace Hospital.Models
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public Department(string name)
        {
            Name = name;
        }
    }
}
