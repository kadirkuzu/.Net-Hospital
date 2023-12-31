using Hospital.Models.Common;
using Hospital.Models.Hospital.RequestDto.Doctor;
using Microsoft.AspNetCore.Mvc;
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
        public ActionResult Create(Guid id)
        {
            ViewBag.clinicId = id;
            return View();
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
    }
}
