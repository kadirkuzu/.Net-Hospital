using Hospital.Models.Common;
using Hospital.Models.Hospital.RequestDto.Department;
using Hospital.Models.Hospital.ResponseDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hospital.MVC.Admin.Controllers
{
    [HospitalAuthorize]
    public class DepartmentController : Controller
    {
        private readonly HttpClient http;

        public DepartmentController(IHttpClientFactory factory)
        {
            http = factory.CreateClient("httpClient");
        }

        public async Task<ActionResult> Index()
        {
            var response = await http.GetAsync("departments");
            IEnumerable<GetDepartmentResponseDto>? departments;
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                departments = JsonConvert.DeserializeObject<List<GetDepartmentResponseDto>>(json);
            }
            else
            {
                departments = Enumerable.Empty<GetDepartmentResponseDto>();
                ModelState.AddModelError(string.Empty, "Error");
            }
            return View(departments);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> SendCreate(AddDepartmentRequestDto request)
        {
            if (ModelState.IsValid)
            {
                var response = await http.PostAsJsonAsync("departments", request);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("");
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    var errorObject = JsonConvert.DeserializeObject<dynamic>(errorContent);
                    ViewBag.ErrorMessage = errorObject?.message;
                    return View("Create");
                }
            }
            return RedirectToAction("Create");
        }

        public async Task<ActionResult> Delete(IDRecord request)
        {
            if (ModelState.IsValid)
            {
                var response = await http.DeleteAsync("departments/" + request.id);
                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    var errorObject = JsonConvert.DeserializeObject<dynamic>(errorContent);
                    TempData["ErrorMessage"] = errorObject?.message.ToString();
                }
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<ActionResult> Details(IDRecord request)
        {
            var response = await http.GetAsync("departments/"+request.id);
            var json = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var department = JsonConvert.DeserializeObject<GetDepartmentResponseDto>(json);
                return View(department);

            }
            else
            {
                var errorObject = JsonConvert.DeserializeObject<dynamic>(json);
                TempData["ErrorMessage"] = errorObject?.message.ToString();
                return RedirectToAction("");
            }
        }
        public ActionResult Edit(UpdateDepartmentRequestDto request)
        {
            return View(request);
        }
        [HttpPost]
        public async Task<ActionResult> SendEdit(UpdateDepartmentRequestDto request)
        {
            if (ModelState.IsValid)
            {
                var response = await http.PutAsJsonAsync("departments/" + request.Id, request);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("");
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    var errorObject = JsonConvert.DeserializeObject<dynamic>(errorContent);
                    ViewBag.ErrorMessage = errorObject?.message.ToString();
                    return View("Edit",request);
                }
            }
            return RedirectToAction("Edit");
        }
    }
}
