using Hospital.Models.Common;
using Hospital.Models.Hospital.RequestDto.Doctor;

namespace Hospital.Models
{
    public class Doctor : Person
    {
        public Guid ClinicId { get; set; }
        public Clinic? Clinic { get; set; }
        public ICollection<WorkSchedule>? WorkSchedules { get; set; }
        public Doctor(AddDoctorRequestDto request)
        {
            Name = request.Name;
            Surname = request.SurName;
            Email = request.Email;
            Phone = request.Phone;
            ClinicId = request.ClinicId;
        }
        public Doctor() { }
    }
}
