using Hospital.Models.Common;

namespace Hospital.Models
{
    public class Doctor : Person
    {
        public Guid ClinicId { get; set; }
        public Clinic? Clinic { get; set; }
        public ICollection<WorkSchedule>? WorkSchedules { get; set; }
        public Doctor(AddDoctorRequest request)
        {
            Name = request.Name;
            Surname = request.SurName;
            Email = request.Email;
            Phone = request.Phone;
            ClinicId = request.ClinicId;
        }
        public Doctor() { }
    }

    public class AddDoctorRequest
    {
        public string Name { get; }
        public string SurName { get; }
        public string Email { get; }
        public string Phone { get; }
        public Guid ClinicId { get; }
    }
    public class DoctorDto
    {
        public Guid Id { get; set; }
        public string Name { get; }
        public string SurName { get; }
        public string Email { get; }
        public string Phone { get; }
        public Guid ClinicId { get; }
        public string ClinicName { get; }
        public IEnumerable<WorkSchedule> WorkSchedules { get; set; }
        public DoctorDto(Doctor doctor)
        {
            Id = doctor.Id;
            Name = doctor.Name;
            SurName = doctor.Surname;
            Email = doctor.Email;
            Phone = doctor.Phone;
            ClinicId= doctor.ClinicId;
            ClinicName = doctor.Clinic!.Name;
            WorkSchedules = doctor.WorkSchedules ?? new List<WorkSchedule>();
        }


    }
}
