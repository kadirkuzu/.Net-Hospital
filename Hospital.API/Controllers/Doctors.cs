using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hospital.Models;
using Hospital.API.Services.Abstract;
using Hospital.Models.Hospital.ResponseDto;
using Hospital.Models.Hospital.RequestDto.Doctor;

namespace Hospital.API.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class Doctors : ControllerBase
    {
        private readonly IDoctorService _doctorService;
        private readonly IClinicService _clinicService;
        private readonly IAppointmentService _appointmentService;

        public Doctors(IDoctorService doctorService , IClinicService clinicService , IAppointmentService appointmentService)
        {
            _doctorService = doctorService ;
            _clinicService = clinicService ;
            _appointmentService = appointmentService ;
        }

        [HttpGet("")]
        public IEnumerable<GetDoctorResponseDto> GetAll()
        {
            return _doctorService.GetAll()
                .Include(x=>x.Clinic)
                .Include(x=>x.WorkSchedules)
                .Select(x=> new GetDoctorResponseDto(x));
        }

        [HttpGet("id")]
        public async Task<IActionResult> Get(Guid id)
        {
            var doctor = await _doctorService.GetAsync(id);
            return doctor is null ? NotFound() : Ok(doctor) ;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddDoctorRequestDto request)
        {
            var clinic = await _clinicService.GetAsync(request.ClinicId);
            if (clinic == null)
            {
                return NotFound("Clinic is not found");
            }
            var doctor = new Doctor(request);
            await _doctorService.AddAsync(doctor);
            await _doctorService.SaveAsync();
            return Ok(doctor);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var doctor = await _doctorService.AsNoTracking().FirstOrDefaultAsync(data => data.Id == id);
            if (doctor == null) return NotFound();
            var anyAppointment = await _appointmentService.GetAll().AnyAsync(x=>x.DoctorId == id);
            if (anyAppointment)
            {
                return NotFound("The doctor have appointments. Remove them to remove doctor.");
            }
            _doctorService.Remove(doctor);
            await _clinicService.SaveAsync();
            return Ok(id);
        }
    }
}
