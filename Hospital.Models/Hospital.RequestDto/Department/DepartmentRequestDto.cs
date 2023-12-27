using System.ComponentModel.DataAnnotations;

namespace Hospital.Models.Hospital.RequestDto
{
    public class DepartmentRequestDto
    {
        [Required]
        [Display(Name="Department Name")]
        public string Name { get; set; }
    }
}
