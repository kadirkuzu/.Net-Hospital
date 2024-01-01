using Hospital.Models.Common;
using Hospital.Models.Hospital.RequestDto.Clinic;
using Hospital.Models.Hospital.RequestDto.WorkSchedules;
using Hospital.Models.Hospital.ResponseDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hospital.MVC.Admin.Controllers
{
    public class WorkScheduleController : Controller
    {
        private readonly HttpClient http;

        public WorkScheduleController(IHttpClientFactory factory)
        {
            http = factory.CreateClient("httpClient");
        }

        public async Task<IActionResult> Index()
        {
            var response = await http.GetAsync("work-schedules");
            IEnumerable<GetWorkScheduleResponseDto>? workSchedules;
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                workSchedules = JsonConvert.DeserializeObject<List<GetWorkScheduleResponseDto>>(json);
            }
            else
            {
                workSchedules = Enumerable.Empty<GetWorkScheduleResponseDto>();
                ModelState.AddModelError(string.Empty, "Error");
            }
            return View(workSchedules);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> SendCreate(AddWorkScheduleRequestDto request)
        {
            if (ModelState.IsValid)
            {
                var response = await http.PostAsJsonAsync("work-schedules", request);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("", "workschedule");
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    var errorObject = JsonConvert.DeserializeObject<dynamic>(errorContent);
                    TempData["ErrorMessage"] = errorObject?.message.ToString();
                    return RedirectToAction("Create");
                }
            }
            return RedirectToAction("Create");
        }

        public async Task<ActionResult> Delete(RemoveClinicRequestDto request)
        {
            if (ModelState.IsValid)
            {
                var response = await http.DeleteAsync("work-schedules/" + request.Id);
                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    var errorObject = JsonConvert.DeserializeObject<dynamic>(errorContent);
                    TempData["ErrorMessage"] = errorObject?.message.ToString();
                }
            }
            return RedirectToAction("", "workSchedule");
        }
    }
}
