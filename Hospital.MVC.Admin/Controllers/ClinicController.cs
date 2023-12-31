using Hospital.Models.Common;
using Hospital.Models.Hospital.RequestDto;
using Hospital.Models.Hospital.RequestDto.Clinic;
using Hospital.Models.Hospital.ResponseDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hospital.MVC.Admin.Controllers
{
    [HospitalAuthorize]
    public class ClinicController : Controller
    {
        private readonly HttpClient http;

        public ClinicController(IHttpClientFactory factory)
        {
            http = factory.CreateClient("httpClient");
        }

        public ActionResult Create(Guid id)
        {
            ViewBag.departmentId = id;
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> SendCreate(AddClinicRequestDto request)
        {
            if (ModelState.IsValid)
            {
                var response = await http.PostAsJsonAsync("clinics", request);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("details","department",new IDRecord (request.DepartmentId));
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    var errorObject = JsonConvert.DeserializeObject<dynamic>(errorContent);
                    TempData["ErrorMessage"] = errorObject?.message.ToString();
                    return RedirectToAction("Create", new IDRecord(request.DepartmentId));
                }
            }
            return RedirectToAction("Create", request.DepartmentId);
        }

        public async Task<ActionResult> Delete(RemoveClinicRequestDto request)
        {
            if (ModelState.IsValid)
            {
                var response = await http.DeleteAsync("clinics/" + request.Id);
                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    var errorObject = JsonConvert.DeserializeObject<dynamic>(errorContent);
                    TempData["ErrorMessage"] = errorObject?.message.ToString();
                }
            }
            return RedirectToAction("details", "department", new IDRecord(request.DepartmentId));
        }

        public ActionResult Edit(UpdateClinicRequestDto request)
        {
            return View(request);
        }
        [HttpPost]
        public async Task<ActionResult> SendEdit(UpdateClinicRequestDto request)
        {
            if (ModelState.IsValid)
            {
                var response = await http.PutAsJsonAsync("clinics/" + request.Id, request);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("details", "department",new IDRecord(request.DepartmentId));
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

        [HttpGet]
        public async Task<ActionResult> Details(GetClinicRequestDto request)
        {
            var response = await http.GetAsync("clinics/" + request.Id);
            var json = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var clinic = JsonConvert.DeserializeObject<GetClinicResponseDto>(json);
                return View(clinic);

            }
            else
            {
                var errorObject = JsonConvert.DeserializeObject<dynamic>(json);
                TempData["ErrorMessage"] = errorObject?.message.ToString();
                return RedirectToAction("details", "department" , new IDRecord(request.DepartmentId));
            }
        }
    }
}
