using Hospital.Models.Hospital.RequestDto;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hospital.MVC.Admin.Models
{
    public class UpdateDoctorViewModel
    {
        public UpdateDoctorRequestDto Request { get; set; }
        public List<SelectListItem> WorkSchedulesList { get; set; }
        public UpdateDoctorViewModel(UpdateDoctorRequestDto request , List<SelectListItem> workSchedulesList)
        {
            Request = request;
            WorkSchedulesList = workSchedulesList;
        }
    }
}
