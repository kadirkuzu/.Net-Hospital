using Hospital.Models.Common;

namespace Hospital.Models
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public Department(string name)
        {
            Name = name;
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
        }
        public Department(Guid id ,string name)
        {
            Name = name;
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            Id = id;
        }
    }
}
