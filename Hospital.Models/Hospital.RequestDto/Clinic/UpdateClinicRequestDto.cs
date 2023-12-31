using System.ComponentModel.DataAnnotations;

namespace Hospital.Models.Hospital.RequestDto.Clinic
{
    public class UpdateClinicRequestDto
    {
        [Required]
        [Display(Name = "Clinic Name")]
        public string Name { get; set; }
        [Required]
        public Guid Id { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
