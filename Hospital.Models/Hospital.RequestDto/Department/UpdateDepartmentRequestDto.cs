using System.ComponentModel.DataAnnotations;

namespace Hospital.Models.Hospital.RequestDto.Department
{
    public class UpdateDepartmentRequestDto
    {
        [Required]
        [Display(Name = "Department Name")]
        public string Name { get; set; }
        [Required]
        public Guid Id { get; set; }
    }
}
