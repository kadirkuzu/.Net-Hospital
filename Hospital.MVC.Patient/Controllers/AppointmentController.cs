using Hospital.Models.Common;
using Hospital.Models.Hospital.RequestDto.Appointment;
using Hospital.Models.Hospital.RequestDto.Clinic;
using Hospital.Models.Hospital.ResponseDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace Hospital.MVC.Patient.Controllers
{
    [HospitalAuthorize]
    public class AppointmentController : Controller
    {
        private readonly HttpClient http;

        public AppointmentController(IHttpClientFactory factory)
        {
            http = factory.CreateClient("httpClient");
        }

        public async Task<IActionResult> Index()
        {
            var response = await http.GetAsync("appointments/only-patient");
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

        public async Task<ActionResult> Create()
        {
            var response = await http.GetAsync("departments");
            var json = await response.Content.ReadAsStringAsync();
            var departments = JsonConvert.DeserializeObject<List<GetDepartmentResponseDto>>(json);
            ViewBag.Departments = new SelectList(departments, "Id", "Name");
            ViewBag.Clinics = new SelectList(new List<SelectListItem>(), "Id", "Name");
            ViewBag.Doctors = new SelectList(new List<SelectListItem>(), "Id", "Name");
            return View(new AddAppointmentRequestDto());
        }

        [HttpPost]
        public async Task<ActionResult> Create(AddAppointmentRequestDto request)
        {
            var response = await http.GetAsync("departments");
            var json = await response.Content.ReadAsStringAsync();
            var departments = JsonConvert.DeserializeObject<List<GetDepartmentResponseDto>>(json);

            var appointmentsResponse = await http.GetAsync("appointments");
            var appointmentJson = await appointmentsResponse.Content.ReadAsStringAsync();
            var appointments = JsonConvert.DeserializeObject<List<GetAppointmentResponseDto>>(appointmentJson);

            ViewBag.Departments = new SelectList(departments, "Id", "Name");

            if (request.DepartmentId == null)
            {
                ViewBag.Clinics = new SelectList(new List<SelectListItem>(), "Id", "Name");
                ViewBag.Doctors = new SelectList(new List<SelectListItem>(), "Id", "Name");
                return View(new AddAppointmentRequestDto());
            }
            else if(request.ClinicId == null)
            {
                var department = departments.FirstOrDefault(x=>x.Id == request.DepartmentId);
                ViewBag.Clinics = new SelectList(department.Clinics, "Id", "Name");
                ViewBag.Doctors = new SelectList(new List<SelectListItem>(), "Id", "Name");
                return View(new AddAppointmentRequestDto() { DepartmentId = request.DepartmentId });
            }
            else if (request.DoctorId == null)
            {
                response = await http.GetAsync("clinics/"+request.ClinicId);
                json = await response.Content.ReadAsStringAsync();
                var clinic = JsonConvert.DeserializeObject<GetClinicResponseDto>(json);

                var department = departments.FirstOrDefault(x => x.Id == request.DepartmentId);

                ViewBag.Clinics = new SelectList(department.Clinics, "Id", "Name");
                ViewBag.Doctors = new SelectList(clinic.Doctors, "Id", "Name");
                return View(new AddAppointmentRequestDto() { DepartmentId = request.DepartmentId , ClinicId = request.ClinicId });
            }
            else if (request.Day == null)
            {
                response = await http.GetAsync("clinics/" + request.ClinicId);
                json = await response.Content.ReadAsStringAsync();
                var clinic = JsonConvert.DeserializeObject<GetClinicResponseDto>(json);
                var department = departments.FirstOrDefault(x => x.Id == request.DepartmentId);

                response = await http.GetAsync("doctors/" + request.DoctorId);
                json = await response.Content.ReadAsStringAsync();
                var doctor = JsonConvert.DeserializeObject<GetDoctorResponseDto>(json);

                var wsDay  = doctor.WorkSchedules.Select(x=>x.Day).Distinct().ToList();

                ViewBag.Days = new SelectList(wsDay);
                ViewBag.Clinics = new SelectList(department.Clinics, "Id", "Name");
                ViewBag.Doctors = new SelectList(clinic.Doctors, "Id", "Name");
                return View(new AddAppointmentRequestDto() { DepartmentId = request.DepartmentId, ClinicId = request.ClinicId , DoctorId = request.DoctorId });
            }
            else if (request.Time == null)
            {
                response = await http.GetAsync("clinics/" + request.ClinicId);
                json = await response.Content.ReadAsStringAsync();
                var clinic = JsonConvert.DeserializeObject<GetClinicResponseDto>(json);
                var department = departments.FirstOrDefault(x => x.Id == request.DepartmentId);

                response = await http.GetAsync("doctors/" + request.DoctorId);
                json = await response.Content.ReadAsStringAsync();
                var doctor = JsonConvert.DeserializeObject<GetDoctorResponseDto>(json);
                var wsDays = doctor.WorkSchedules.Select(x => x.Day).Distinct().ToList();

                var ws = doctor.WorkSchedules.FirstOrDefault(x => x.Day == request.Day);

                List<TimeSpan> wsTimes = GenerateTimeSlots(ws.StartTime, ws.EndTime, TimeSpan.FromMinutes(15));

                wsTimes = wsTimes.Where(time =>!appointments
                        .FindAll(x => x.DoctorId == request.DoctorId && x.Day == request.Day)
                        .Select(x => x.Time)
                        .Contains(time)).ToList();

                ViewBag.Days = new SelectList(wsDays);
                ViewBag.Times = new SelectList(wsTimes);
                ViewBag.Clinics = new SelectList(department.Clinics, "Id", "Name");
                ViewBag.Doctors = new SelectList(clinic.Doctors, "Id", "Name");
                return View(new AddAppointmentRequestDto() { DepartmentId = request.DepartmentId, ClinicId = request.ClinicId, DoctorId = request.DoctorId , Day = request.Day });
            }
            else return RedirectToAction("SendCreate",request);
        }

        public async Task<ActionResult> SendCreate(AddAppointmentRequestDto request)
        {
            if (ModelState.IsValid)
            {
                var response = await http.PostAsJsonAsync("appointments", request);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("", "Appointment");
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

        public List<TimeSpan> GenerateTimeSlots(TimeSpan startTime, TimeSpan endTime, TimeSpan interval)
        {
            List<TimeSpan> timeSlots = new List<TimeSpan>();

            TimeSpan currentTime = startTime;

            while (currentTime < endTime)
            {
                timeSlots.Add(currentTime);
                currentTime = currentTime.Add(interval);
            }

            return timeSlots;
        }

        public async Task<ActionResult> Delete(IDRecord request)
        {
            if (ModelState.IsValid)
            {
                await http.DeleteAsync("appointments/" + request.id);
            }
            return RedirectToAction("");
        }
    }
}
