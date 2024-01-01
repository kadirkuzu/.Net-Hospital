using Hospital.Models.Hospital.ResponseDto;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Models.Hospital.RequestDto
{
    public class UpdateDoctorRequestDto
    {
        public Guid Id { get; set; }
        public Guid ClinicId { get; set; }
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
        public List<string> WorkSchedules { get; set; }

        public UpdateDoctorRequestDto(GetDoctorResponseDto doctor)
        {
            Id = doctor.Id;
            ClinicId = doctor.ClinicId;
            Name = doctor.Name;
            Surname = doctor.Surname;
            Email = doctor.Email;
            Phone = doctor.Phone;
            WorkSchedules = doctor.WorkSchedules!=null ? doctor.WorkSchedules.Select(x => x.Id.ToString()).ToList() : new List<string>();
        }
        public UpdateDoctorRequestDto()
        {
            
        }
    }
}
