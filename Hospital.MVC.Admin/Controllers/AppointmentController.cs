using Hospital.Models.Hospital.ResponseDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hospital.MVC.Admin.Controllers
{
    [HospitalAuthorize]
    public class AppointmentController : Controller
    {
        private readonly HttpClient http;

        public AppointmentController(IHttpClientFactory factory)
        {
            http = factory.CreateClient("httpClient");
        }
        public async Task<ActionResult> Index()
        {
            var response = await http.GetAsync("appointments");
            IEnumerable<GetAppointmentResponseDto>? appointments;
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                appointments = JsonConvert.DeserializeObject<List<GetAppointmentResponseDto>>(json);
            }
            else
            {
                appointments = Enumerable.Empty<GetAppointmentResponseDto>();
                ModelState.AddModelError(string.Empty, "Error");
            }
            return View(appointments);
        }
    }
}
