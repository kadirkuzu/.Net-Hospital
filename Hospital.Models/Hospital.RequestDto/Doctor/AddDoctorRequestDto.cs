using System.ComponentModel.DataAnnotations;

namespace Hospital.Models.Hospital.RequestDto.Doctor
{
    public class AddDoctorRequestDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }
        [Required]
        public IEnumerable<string> WorkSchedules { get; set; }
        [Required]
        public Guid ClinicId { get; set; }

        public AddDoctorRequestDto()
        {
            
        }
    }
}
