using Hospital.Models.Hospital.RequestDto.Doctor;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hospital.MVC.Admin.Models
{
    public class AddDoctorViewModel
    {
        public AddDoctorRequestDto Request { get; set; }
        public List<SelectListItem> WorkSchedulesList { get; set; }
        public AddDoctorViewModel(List<SelectListItem> workSchedulesList , Guid clinicId)
        {
            Request = new() {
                ClinicId = clinicId
            };
            WorkSchedulesList = workSchedulesList;
        }
    }
}
