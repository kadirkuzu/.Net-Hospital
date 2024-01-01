using Hospital.Models.Common;
using Hospital.Models.Hospital.RequestDto;
using Hospital.Models.Hospital.RequestDto.Clinic;
using Hospital.Models.Hospital.RequestDto.Doctor;
using Hospital.Models.Hospital.ResponseDto;
using Hospital.MVC.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace Hospital.MVC.Admin.Controllers
{
    public class DoctorController : Controller
    {
        private readonly HttpClient http;

        public DoctorController(IHttpClientFactory factory)
        {
            http = factory.CreateClient("httpClient");
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> Create(Guid id)
        {
            var response = await http.GetAsync("work-schedules");
            var json = await response.Content.ReadAsStringAsync();
            var workSchedules = JsonConvert.DeserializeObject<List<GetWorkScheduleResponseDto>>(json);
            var selectList = workSchedules?.Select(x => new SelectListItem { Text = x.Day + x.StartTime.ToString() + "-" + x.EndTime.ToString(), Value = x.Id.ToString() });
            var model = new AddDoctorViewModel(selectList?.ToList() ?? new List<SelectListItem>(),id);
            return View(model);
        }
        [HttpPost]
        public async Task<ActionResult> SendCreate(AddDoctorRequestDto request)
        {
            if (ModelState.IsValid)
            {
                var response = await http.PostAsJsonAsync("doctors", request);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("details", "clinic", new IDRecord(request.ClinicId));
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    var errorObject = JsonConvert.DeserializeObject<dynamic>(errorContent);
                    TempData["ErrorMessage"] = errorObject?.message.ToString();
                    return RedirectToAction("Create", new IDRecord(request.ClinicId));
                }
            }
            return RedirectToAction("Create", request.ClinicId);
        }
        public async Task<ActionResult> Delete(RemoveDoctorRequestDto request)
        {
            if (ModelState.IsValid)
            {
                var response = await http.DeleteAsync("doctors/" + request.Id);
                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    var errorObject = JsonConvert.DeserializeObject<dynamic>(errorContent);
                    TempData["ErrorMessage"] = errorObject?.message.ToString();
                }
            }
            return RedirectToAction("details", "clinic", new IDRecord(request.ClinicId));
        }

        public async Task<ActionResult> Edit(Guid id)
        {
            var response = await http.GetAsync("work-schedules");
            var json = await response.Content.ReadAsStringAsync();
            var workSchedules = JsonConvert.DeserializeObject<List<GetWorkScheduleResponseDto>>(json);
            var selectList = workSchedules?.Select(x => new SelectListItem { Text = x.Day + x.StartTime.ToString() + "-" + x.EndTime.ToString(), Value = x.Id.ToString() });

            var doctorResponse = await http.GetAsync("doctors/"+id);
            var doctorJson = await doctorResponse.Content.ReadAsStringAsync();
            var doctor = JsonConvert.DeserializeObject<GetDoctorResponseDto>(doctorJson);

            var request = new UpdateDoctorRequestDto(doctor);

            var model = new UpdateDoctorViewModel(request , selectList?.ToList() ?? new List<SelectListItem>());
            return View(model);
        }

        public async Task<ActionResult> SendEdit(UpdateDoctorRequestDto request)
        {
            if (ModelState.IsValid)
            {
                var response = await http.PutAsJsonAsync("doctors/" + request.Id, request);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("details", "clinic", new IDRecord(request.ClinicId));
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    var errorObject = JsonConvert.DeserializeObject<dynamic>(errorContent);
                    ViewBag.ErrorMessage = errorObject?.message.ToString();
                    return View("Edit", request);
                }
            }
            return RedirectToAction("Edit");
        }
    }
}
