using Azure.Core;
using Hospital.Models.Common;
using Hospital.Models.Hospital.RequestDto;
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
        public async Task<ActionResult> SendCreate(DepartmentRequestDto request)
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

        public async Task<ActionResult> Delete(DeleteRecord request)
        {
            if (ModelState.IsValid)
            {
                var result =await http.DeleteAsync("departments/" + request.id);
            }
            return RedirectToAction("");
        }
    }
}
