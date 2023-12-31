using System.ComponentModel.DataAnnotations;

namespace Hospital.Models.Hospital.RequestDto.Department
{
    public class AddDepartmentRequestDto
    {
        [Required]
        [Display(Name = "Department Name")]
        public string Name { get; set; }
    }
}
